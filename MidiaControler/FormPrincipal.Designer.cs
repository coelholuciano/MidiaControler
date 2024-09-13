namespace MidiaControler
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            notifyIconBandeja = new NotifyIcon(components);
            contextMenuStripBandeja = new ContextMenuStrip(components);
            abrirToolStripMenuItem = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            comboBoxTecla1 = new ComboBox();
            comboBoxTecla2 = new ComboBox();
            comboBoxUp = new ComboBox();
            comboBoxDown = new ComboBox();
            comboBoxAvancar = new ComboBox();
            comboBoxVoltar = new ComboBox();
            comboBoxPlayPause = new ComboBox();
            buttonBandeja = new Button();
            labelTecla1 = new Label();
            labelTecla2 = new Label();
            labelPlayPause = new Label();
            labelVolDown = new Label();
            labelVoltar = new Label();
            labelVolUp = new Label();
            labelAvancar = new Label();
            buttonSalvar = new Button();
            contextMenuStripBandeja.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIconBandeja
            // 
            notifyIconBandeja.BalloonTipIcon = ToolTipIcon.Info;
            notifyIconBandeja.BalloonTipText = "Aplicação continua executando na bandeja, use os controles para controlar sua mídia.";
            notifyIconBandeja.BalloonTipTitle = "Controle de Mídia do Zé";
            notifyIconBandeja.ContextMenuStrip = contextMenuStripBandeja;
            notifyIconBandeja.Icon = (Icon)resources.GetObject("notifyIconBandeja.Icon");
            notifyIconBandeja.Text = "Controle de Mídia do Zé";
            notifyIconBandeja.MouseDoubleClick += NotifyIconBandeja_MouseDoubleClick;
            // 
            // contextMenuStripBandeja
            // 
            contextMenuStripBandeja.Items.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, encerrarToolStripMenuItem });
            contextMenuStripBandeja.Name = "contextMenuStripBandeja";
            contextMenuStripBandeja.Size = new Size(118, 48);
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(117, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += AbrirToolStripMenuItem_Click;
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(117, 22);
            encerrarToolStripMenuItem.Text = "Encerrar";
            encerrarToolStripMenuItem.Click += EncerrarToolStripMenuItem_Click;
            // 
            // comboBoxTecla1
            // 
            comboBoxTecla1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTecla1.FormattingEnabled = true;
            comboBoxTecla1.Items.AddRange(new object[] { "SHIFT", "CONTROL", "WIN", "ALT" });
            comboBoxTecla1.Location = new Point(10, 30);
            comboBoxTecla1.Name = "comboBoxTecla1";
            comboBoxTecla1.RightToLeft = RightToLeft.No;
            comboBoxTecla1.Size = new Size(100, 23);
            comboBoxTecla1.TabIndex = 7;
            comboBoxTecla1.TabStop = false;
            // 
            // comboBoxTecla2
            // 
            comboBoxTecla2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTecla2.FormattingEnabled = true;
            comboBoxTecla2.Items.AddRange(new object[] { "SHIFT", "CONTROL", "WIN", "ALT" });
            comboBoxTecla2.Location = new Point(140, 30);
            comboBoxTecla2.Name = "comboBoxTecla2";
            comboBoxTecla2.Size = new Size(100, 23);
            comboBoxTecla2.TabIndex = 8;
            comboBoxTecla2.TabStop = false;
            // 
            // comboBoxUp
            // 
            comboBoxUp.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUp.FormattingEnabled = true;
            comboBoxUp.Items.AddRange(new object[] { "Insert", "Delete", "Home", "End", "PageUp", "PageUp", "Left", "Right", "Up", "Down", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" });
            comboBoxUp.Location = new Point(10, 140);
            comboBoxUp.Name = "comboBoxUp";
            comboBoxUp.Size = new Size(70, 23);
            comboBoxUp.TabIndex = 9;
            comboBoxUp.TabStop = false;
            // 
            // comboBoxDown
            // 
            comboBoxDown.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDown.FormattingEnabled = true;
            comboBoxDown.Items.AddRange(new object[] { "Insert", "Delete", "Home", "End", "PageUp", "PageUp", "Left", "Right", "Up", "Down", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" });
            comboBoxDown.Location = new Point(90, 140);
            comboBoxDown.Name = "comboBoxDown";
            comboBoxDown.Size = new Size(70, 23);
            comboBoxDown.TabIndex = 10;
            comboBoxDown.TabStop = false;
            // 
            // comboBoxAvancar
            // 
            comboBoxAvancar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAvancar.FormattingEnabled = true;
            comboBoxAvancar.Items.AddRange(new object[] { "Insert", "Delete", "Home", "End", "PageUp", "PageUp", "Left", "Right", "Up", "Down", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" });
            comboBoxAvancar.Location = new Point(170, 90);
            comboBoxAvancar.Name = "comboBoxAvancar";
            comboBoxAvancar.Size = new Size(70, 23);
            comboBoxAvancar.TabIndex = 11;
            comboBoxAvancar.TabStop = false;
            // 
            // comboBoxVoltar
            // 
            comboBoxVoltar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVoltar.FormattingEnabled = true;
            comboBoxVoltar.Items.AddRange(new object[] { "Insert", "Delete", "Home", "End", "PageUp", "PageUp", "Left", "Right", "Up", "Down", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" });
            comboBoxVoltar.Location = new Point(90, 90);
            comboBoxVoltar.Name = "comboBoxVoltar";
            comboBoxVoltar.Size = new Size(70, 23);
            comboBoxVoltar.TabIndex = 12;
            comboBoxVoltar.TabStop = false;
            // 
            // comboBoxPlayPause
            // 
            comboBoxPlayPause.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPlayPause.FormattingEnabled = true;
            comboBoxPlayPause.Items.AddRange(new object[] { "Insert", "Delete", "Home", "End", "PageUp", "PageUp", "Left", "Right", "Up", "Down", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" });
            comboBoxPlayPause.Location = new Point(10, 90);
            comboBoxPlayPause.Name = "comboBoxPlayPause";
            comboBoxPlayPause.Size = new Size(70, 23);
            comboBoxPlayPause.TabIndex = 13;
            comboBoxPlayPause.TabStop = false;
            // 
            // buttonBandeja
            // 
            buttonBandeja.BackColor = SystemColors.ActiveCaption;
            buttonBandeja.Location = new Point(10, 243);
            buttonBandeja.Name = "buttonBandeja";
            buttonBandeja.Size = new Size(230, 31);
            buttonBandeja.TabIndex = 14;
            buttonBandeja.Text = "Bandeja";
            buttonBandeja.UseVisualStyleBackColor = false;
            buttonBandeja.Click += ButtonFechar_Click;
            // 
            // labelTecla1
            // 
            labelTecla1.AutoSize = true;
            labelTecla1.Location = new Point(10, 10);
            labelTecla1.Name = "labelTecla1";
            labelTecla1.Size = new Size(42, 15);
            labelTecla1.TabIndex = 15;
            labelTecla1.Text = "Tecla 1";
            // 
            // labelTecla2
            // 
            labelTecla2.AutoSize = true;
            labelTecla2.Location = new Point(140, 10);
            labelTecla2.Name = "labelTecla2";
            labelTecla2.Size = new Size(42, 15);
            labelTecla2.TabIndex = 16;
            labelTecla2.Text = "Tecla 2";
            // 
            // labelPlayPause
            // 
            labelPlayPause.AutoSize = true;
            labelPlayPause.Location = new Point(10, 70);
            labelPlayPause.Name = "labelPlayPause";
            labelPlayPause.Size = new Size(65, 15);
            labelPlayPause.TabIndex = 17;
            labelPlayPause.Text = "Play/Pause";
            // 
            // labelVolDown
            // 
            labelVolDown.AutoSize = true;
            labelVolDown.Location = new Point(90, 120);
            labelVolDown.Name = "labelVolDown";
            labelVolDown.Size = new Size(65, 15);
            labelVolDown.TabIndex = 18;
            labelVolDown.Text = "Vol - Down";
            // 
            // labelVoltar
            // 
            labelVoltar.AutoSize = true;
            labelVoltar.Location = new Point(90, 70);
            labelVoltar.Name = "labelVoltar";
            labelVoltar.Size = new Size(37, 15);
            labelVoltar.TabIndex = 19;
            labelVoltar.Text = "Voltar";
            // 
            // labelVolUp
            // 
            labelVolUp.AutoSize = true;
            labelVolUp.Location = new Point(10, 120);
            labelVolUp.Name = "labelVolUp";
            labelVolUp.Size = new Size(49, 15);
            labelVolUp.TabIndex = 20;
            labelVolUp.Text = "Vol - Up";
            // 
            // labelAvancar
            // 
            labelAvancar.AutoSize = true;
            labelAvancar.Location = new Point(170, 70);
            labelAvancar.Name = "labelAvancar";
            labelAvancar.Size = new Size(50, 15);
            labelAvancar.TabIndex = 21;
            labelAvancar.Text = "Avançar";
            // 
            // buttonSalvar
            // 
            buttonSalvar.BackColor = SystemColors.ActiveCaption;
            buttonSalvar.Location = new Point(10, 179);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(230, 31);
            buttonSalvar.TabIndex = 22;
            buttonSalvar.Text = "Salvar Configurações";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += ButtonSalvar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 286);
            Controls.Add(buttonSalvar);
            Controls.Add(labelAvancar);
            Controls.Add(labelVolUp);
            Controls.Add(labelVoltar);
            Controls.Add(labelVolDown);
            Controls.Add(labelPlayPause);
            Controls.Add(labelTecla2);
            Controls.Add(labelTecla1);
            Controls.Add(buttonBandeja);
            Controls.Add(comboBoxPlayPause);
            Controls.Add(comboBoxVoltar);
            Controls.Add(comboBoxAvancar);
            Controls.Add(comboBoxDown);
            Controls.Add(comboBoxUp);
            Controls.Add(comboBoxTecla2);
            Controls.Add(comboBoxTecla1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Mídia do Zé";
            FormClosing += FormPrincipal_FormClosing;
            Resize += FormPrincipal_Resize;
            contextMenuStripBandeja.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NotifyIcon notifyIconBandeja;
        private ContextMenuStrip contextMenuStripBandeja;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ComboBox comboBoxTecla1;
        private ComboBox comboBoxTecla2;
        private ComboBox comboBoxUp;
        private ComboBox comboBoxDown;
        private ComboBox comboBoxAvancar;
        private ComboBox comboBoxVoltar;
        private ComboBox comboBoxPlayPause;
        private Label labelTecla1;
        private Label labelTecla2;
        private Label labelPlayPause;
        private Label labelVolDown;
        private Label labelVoltar;
        private Label labelVolUp;
        private Label labelAvancar;
        private Button buttonBandeja;
        private Button buttonSalvar;
    }
}
