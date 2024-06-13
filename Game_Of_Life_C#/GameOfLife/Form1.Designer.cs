namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAzzera = new System.Windows.Forms.Button();
            this.btnProssimo = new System.Windows.Forms.Button();
            this.btnCrea = new System.Windows.Forms.Button();
            this.flpMondo = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbSchemi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGenerazioni = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlOperazioni = new System.Windows.Forms.Panel();
            this.cbxPiano = new System.Windows.Forms.CheckBox();
            this.cbxVeloce = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarVelocita = new System.Windows.Forms.TrackBar();
            this.btnColorGame = new System.Windows.Forms.Button();
            this.btnColorGriglia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.colorDialogGame = new System.Windows.Forms.ColorDialog();
            this.pnlOperazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocita)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAzzera
            // 
            this.btnAzzera.Location = new System.Drawing.Point(9, 16);
            this.btnAzzera.Margin = new System.Windows.Forms.Padding(4);
            this.btnAzzera.Name = "btnAzzera";
            this.btnAzzera.Size = new System.Drawing.Size(141, 53);
            this.btnAzzera.TabIndex = 4;
            this.btnAzzera.Text = "Azzera griglia";
            this.btnAzzera.UseVisualStyleBackColor = true;
            this.btnAzzera.Click += new System.EventHandler(this.btnAzzera_Click);
            // 
            // btnProssimo
            // 
            this.btnProssimo.Location = new System.Drawing.Point(9, 98);
            this.btnProssimo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProssimo.Name = "btnProssimo";
            this.btnProssimo.Size = new System.Drawing.Size(141, 43);
            this.btnProssimo.TabIndex = 1;
            this.btnProssimo.Text = "Prossimo";
            this.btnProssimo.UseVisualStyleBackColor = true;
            this.btnProssimo.Click += new System.EventHandler(this.btnProssimo_Click);
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(13, 29);
            this.btnCrea.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(141, 53);
            this.btnCrea.TabIndex = 0;
            this.btnCrea.Text = "Crea griglia";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // flpMondo
            // 
            this.flpMondo.BackColor = System.Drawing.Color.White;
            this.flpMondo.Location = new System.Drawing.Point(183, 9);
            this.flpMondo.Margin = new System.Windows.Forms.Padding(0);
            this.flpMondo.Name = "flpMondo";
            this.flpMondo.Size = new System.Drawing.Size(800, 800);
            this.flpMondo.TabIndex = 11;
            this.flpMondo.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inserisci dimensione griglia";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 149);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 42);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Inizia";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbSchemi
            // 
            this.cmbSchemi.FormattingEnabled = true;
            this.cmbSchemi.Location = new System.Drawing.Point(8, 548);
            this.cmbSchemi.Name = "cmbSchemi";
            this.cmbSchemi.Size = new System.Drawing.Size(141, 24);
            this.cmbSchemi.TabIndex = 10;
            this.cmbSchemi.SelectedIndexChanged += new System.EventHandler(this.cmbSchemi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Schemi predefiniti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Generazioni trascorse";
            // 
            // txtGenerazioni
            // 
            this.txtGenerazioni.Location = new System.Drawing.Point(9, 494);
            this.txtGenerazioni.Name = "txtGenerazioni";
            this.txtGenerazioni.ReadOnly = true;
            this.txtGenerazioni.Size = new System.Drawing.Size(141, 22);
            this.txtGenerazioni.TabIndex = 8;
            this.txtGenerazioni.Text = "0";
            this.txtGenerazioni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(9, 199);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(141, 42);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pnlOperazioni
            // 
            this.pnlOperazioni.Controls.Add(this.cbxPiano);
            this.pnlOperazioni.Controls.Add(this.cbxVeloce);
            this.pnlOperazioni.Controls.Add(this.label8);
            this.pnlOperazioni.Controls.Add(this.label7);
            this.pnlOperazioni.Controls.Add(this.trackBarVelocita);
            this.pnlOperazioni.Controls.Add(this.btnColorGame);
            this.pnlOperazioni.Controls.Add(this.btnColorGriglia);
            this.pnlOperazioni.Controls.Add(this.label6);
            this.pnlOperazioni.Controls.Add(this.label5);
            this.pnlOperazioni.Controls.Add(this.label4);
            this.pnlOperazioni.Controls.Add(this.cmbSchemi);
            this.pnlOperazioni.Controls.Add(this.label2);
            this.pnlOperazioni.Controls.Add(this.btnStop);
            this.pnlOperazioni.Controls.Add(this.txtGenerazioni);
            this.pnlOperazioni.Controls.Add(this.label3);
            this.pnlOperazioni.Controls.Add(this.btnStart);
            this.pnlOperazioni.Controls.Add(this.btnProssimo);
            this.pnlOperazioni.Controls.Add(this.btnAzzera);
            this.pnlOperazioni.Location = new System.Drawing.Point(4, 93);
            this.pnlOperazioni.Name = "pnlOperazioni";
            this.pnlOperazioni.Size = new System.Drawing.Size(175, 581);
            this.pnlOperazioni.TabIndex = 12;
            // 
            // cbxPiano
            // 
            this.cbxPiano.AutoSize = true;
            this.cbxPiano.Location = new System.Drawing.Point(104, 361);
            this.cbxPiano.Name = "cbxPiano";
            this.cbxPiano.Size = new System.Drawing.Size(15, 14);
            this.cbxPiano.TabIndex = 25;
            this.cbxPiano.UseVisualStyleBackColor = true;
            this.cbxPiano.CheckedChanged += new System.EventHandler(this.cbxPiano_CheckedChanged);
            // 
            // cbxVeloce
            // 
            this.cbxVeloce.AutoSize = true;
            this.cbxVeloce.Location = new System.Drawing.Point(104, 336);
            this.cbxVeloce.Name = "cbxVeloce";
            this.cbxVeloce.Size = new System.Drawing.Size(15, 14);
            this.cbxVeloce.TabIndex = 24;
            this.cbxVeloce.UseVisualStyleBackColor = true;
            this.cbxVeloce.CheckedChanged += new System.EventHandler(this.cbxVeloce_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Molto piano";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Molto veloce";
            // 
            // trackBarVelocita
            // 
            this.trackBarVelocita.LargeChange = 1;
            this.trackBarVelocita.Location = new System.Drawing.Point(9, 276);
            this.trackBarVelocita.Name = "trackBarVelocita";
            this.trackBarVelocita.Size = new System.Drawing.Size(141, 45);
            this.trackBarVelocita.TabIndex = 21;
            this.trackBarVelocita.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarVelocita.Value = 5;
            this.trackBarVelocita.Scroll += new System.EventHandler(this.trackBarVelocita_Scroll);
            // 
            // btnColorGame
            // 
            this.btnColorGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorGame.Location = new System.Drawing.Point(100, 420);
            this.btnColorGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnColorGame.Name = "btnColorGame";
            this.btnColorGame.Size = new System.Drawing.Size(50, 30);
            this.btnColorGame.TabIndex = 20;
            this.btnColorGame.UseVisualStyleBackColor = true;
            this.btnColorGame.Click += new System.EventHandler(this.btnColorGame_Click);
            // 
            // btnColorGriglia
            // 
            this.btnColorGriglia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorGriglia.Location = new System.Drawing.Point(100, 387);
            this.btnColorGriglia.Margin = new System.Windows.Forms.Padding(4);
            this.btnColorGriglia.Name = "btnColorGriglia";
            this.btnColorGriglia.Size = new System.Drawing.Size(50, 30);
            this.btnColorGriglia.TabIndex = 19;
            this.btnColorGriglia.UseVisualStyleBackColor = true;
            this.btnColorGriglia.Click += new System.EventHandler(this.btnColorGriglia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Colore game";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Colore griglia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Velocita esecuzione";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.btnProssimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 811);
            this.Controls.Add(this.pnlOperazioni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpMondo);
            this.Controls.Add(this.btnCrea);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOperazioni.ResumeLayout(false);
            this.pnlOperazioni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzzera;
        private System.Windows.Forms.Button btnProssimo;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.FlowLayoutPanel flpMondo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbSchemi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGenerazioni;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel pnlOperazioni;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnColorGame;
        private System.Windows.Forms.Button btnColorGriglia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialogGame;
        private System.Windows.Forms.TrackBar trackBarVelocita;
        private System.Windows.Forms.CheckBox cbxPiano;
        private System.Windows.Forms.CheckBox cbxVeloce;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

