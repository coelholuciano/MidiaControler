using System.Configuration;
using System.Runtime.InteropServices;

namespace MidiaControler;

public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();

        // selecionar conforme arquivo de configuração
        comboBoxTecla1.SelectedItem = ConfigurationManager.AppSettings.Get("TECLA1");
        comboBoxTecla2.SelectedItem = ConfigurationManager.AppSettings.Get("TECLA2");
        comboBoxPlayPause.SelectedItem = ConfigurationManager.AppSettings.Get("PLAY");
        comboBoxAvancar.SelectedItem = ConfigurationManager.AppSettings.Get("AVANCAR");
        comboBoxVoltar.SelectedItem = ConfigurationManager.AppSettings.Get("VOLTAR");
        comboBoxUp.SelectedItem = ConfigurationManager.AppSettings.Get("UP");
        comboBoxDown.SelectedItem = ConfigurationManager.AppSettings.Get("DOWN");

        // registrar a configuração de atalhos no windows
        RegisterGlobalHotKey();

        // remove os botões do form
        this.ControlBox = false;

        // já abre minimizado
        this.WindowState = FormWindowState.Minimized;
    }


    #region Controles do Form - system tray

    private void FormPrincipal_Resize(object sender, EventArgs e)
    {
        if (this.WindowState == FormWindowState.Minimized)
        {
            this.Hide();
            notifyIconBandeja.Visible = true;
            notifyIconBandeja.ShowBalloonTip(300);
        }
        else if (FormWindowState.Normal == this.WindowState)
        {
            notifyIconBandeja.Visible = false;
        }
    }

    private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
        //cancela o evento fechar
        e.Cancel = true;
        //minimiza a janela
        this.WindowState = FormWindowState.Minimized;
    }

    private void NotifyIconBandeja_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        Show();
        WindowState = FormWindowState.Normal;
        notifyIconBandeja.Visible = false;
    }

    private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
    {
        NotifyIconBandeja_MouseDoubleClick(sender, null);
    }

    private void EncerrarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // limpa os atalhos do windows
        UnregisterGlobalHotKey();

        // forçar o encerramento da aplicação
        Application.Exit();
        Environment.Exit(1);
    }

    #endregion


    #region Salvar as Configurações dos atalhos

    private void ButtonSalvar_Click(object sender, EventArgs e)
    {
        //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings.Remove("TECLA1");
        config.AppSettings.Settings.Remove("TECLA2");
        config.AppSettings.Settings.Remove("PLAY");
        config.AppSettings.Settings.Remove("AVANCAR");
        config.AppSettings.Settings.Remove("VOLTAR");
        config.AppSettings.Settings.Remove("UP");
        config.AppSettings.Settings.Remove("DOWN");

        config.AppSettings.Settings.Add("TECLA1", comboBoxTecla1.Text);
        config.AppSettings.Settings.Add("TECLA2", comboBoxTecla2.Text);
        config.AppSettings.Settings.Add("PLAY", comboBoxPlayPause.Text);
        config.AppSettings.Settings.Add("AVANCAR", comboBoxAvancar.Text);
        config.AppSettings.Settings.Add("VOLTAR", comboBoxVoltar.Text);
        config.AppSettings.Settings.Add("UP", comboBoxUp.Text);
        config.AppSettings.Settings.Add("DOWN", comboBoxDown.Text);

        config.Save(ConfigurationSaveMode.Modified);
        ConfigurationManager.RefreshSection("appSettings");

        // revogar e registrar os atalhos
        UnregisterGlobalHotKey();
        RegisterGlobalHotKey();

        MessageBox.Show("Atalhos atualizados com sucesso!");

        //minimiza a janela
        this.WindowState = FormWindowState.Minimized;
    }

    #endregion


    #region Atalhos do Windows

    private enum MediaKey : byte
    {
        PlayPause = 0xB3,
        Stop = 0xB2,
        NextTrack = 0xB0,
        PrevTrack = 0xB1,
        Up = 0xAF,
        Down = 0xAE
    }

    [DllImport("user32.dll", SetLastError = true)]
    private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

    [DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

    [DllImport("user32.dll")]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);


    private static void SendMediaKey(MediaKey key)
    {
        const int KEYEVENTF_KEYUP = 0x0002;
        keybd_event((byte)key, 0, 0, 0);
        keybd_event((byte)key, 0, KEYEVENTF_KEYUP, 0);
    }

    protected override void WndProc(ref Message m)
    {
        const int WM_HOTKEY = 0x0312;

        if (m.Msg == WM_HOTKEY)
        {
            int id = m.WParam.ToInt32();
            if (id == 1) // ID do atalho registrado
            {
                SendMediaKey(MediaKey.PlayPause);
            }
            else if (id == 2)
            {
                SendMediaKey(MediaKey.NextTrack);
            }
            else if (id == 3)
            {
                SendMediaKey(MediaKey.PrevTrack);
            }
            else if (id == 4)
            {
                SendMediaKey(MediaKey.Up);
            }
            else if (id == 5)
            {
                SendMediaKey(MediaKey.Down);
            }
        }
        base.WndProc(ref m);
    }

    private void RegisterGlobalHotKey()
    {
        const int MOD_SHIFT = 0x0004;
        const int MOD_CONTROL = 0x0002;
        const int MOD_WIN = 0x0008;
        const int MOD_ALT = 0x0001;

        uint tecla1 = 0x0002;
        uint tecla2 = 0x0001;

        switch (ConfigurationManager.AppSettings.Get("TECLA1"))
        {
            case "CONTROL":
                tecla1 = MOD_CONTROL;
                break;
            case "ALT":
                tecla1 = MOD_ALT;
                break;
            case "SHIFT":
                tecla1 = MOD_SHIFT;
                break;
            case "WIN":
                tecla1 = MOD_WIN;
                break;
        }

        switch (ConfigurationManager.AppSettings.Get("TECLA2"))
        {
            case "CONTROL":
                tecla2 = MOD_CONTROL;
                break;
            case "ALT":
                tecla2 = MOD_ALT;
                break;
            case "SHIFT":
                tecla2 = MOD_SHIFT;
                break;
            case "WIN":
                tecla2 = MOD_WIN;
                break;
        }

        // play/pause
        RegisterHotKey(this.Handle, 1, tecla1 | tecla2, (uint)(Keys)Enum.Parse(typeof(Keys), ConfigurationManager.AppSettings.Get("PLAY")));
        // avança
        RegisterHotKey(this.Handle, 2, tecla1 | tecla2, (uint)(Keys)Enum.Parse(typeof(Keys), ConfigurationManager.AppSettings.Get("AVANCAR")));
        // volta
        RegisterHotKey(this.Handle, 3, tecla1 | tecla2, (uint)(Keys)Enum.Parse(typeof(Keys), ConfigurationManager.AppSettings.Get("VOLTAR")));
        // vol up
        RegisterHotKey(this.Handle, 4, tecla1 | tecla2, (uint)(Keys)Enum.Parse(typeof(Keys), ConfigurationManager.AppSettings.Get("UP")));
        // vol down
        RegisterHotKey(this.Handle, 5, tecla1 | tecla2, (uint)(Keys)Enum.Parse(typeof(Keys), ConfigurationManager.AppSettings.Get("DOWN")));
    }

    private void UnregisterGlobalHotKey()
    {
        UnregisterHotKey(this.Handle, 1);
        UnregisterHotKey(this.Handle, 2);
        UnregisterHotKey(this.Handle, 3);
        UnregisterHotKey(this.Handle, 4);
        UnregisterHotKey(this.Handle, 5);
    }

    #endregion

}