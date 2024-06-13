using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GameOfLife mondo = null;
        List<Cella> listaCelle = new List<Cella>();
        int con = 0, btnRiga;
        const int NUM = 400; //numero di celle(quadrato perfetto)
        string[] schemi = { "Blinker", "Glider", "Small exploder", "Pulsar", "10 cell row", "Tumbler" };
        bool flag = false;

        //colore iniziale griglia
        Color cGriglia = Color.White;
        //colore iniziale gioco
        Color cGame = Color.Red;
        int veloce;

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlOperazioni.Enabled = false;
            btnStop.Enabled = false;
            cmbSchemi.Items.AddRange(schemi);
            btnColorGriglia.BackColor = cGriglia;
            btnColorGame.BackColor = cGame;
        }

        #region Controlla
        private void Controlla()
        {
            for (int i = 0; i < flpMondo.Controls.Count; i++)
            {
                if (mondo[Convert.ToInt32(flpMondo.Controls[i].Name), Convert.ToInt32(flpMondo.Controls[i].Tag)])
                    flpMondo.Controls[i].BackColor = cGame;
                else
                if (!mondo[Convert.ToInt32(flpMondo.Controls[i].Name), Convert.ToInt32(flpMondo.Controls[i].Tag)])
                    flpMondo.Controls[i].BackColor = cGriglia;
            }
        }
        #endregion

        #region Azzera
        public void Azzera()
        {
            timer.Stop();
            con = 0;
            txtGenerazioni.Text = con.ToString();
            mondo.Azzera();
            Controlla();
        }

        private void btnAzzera_Click(object sender, EventArgs e)
        {
            Azzera();
        }
        #endregion

        #region InterazioneMondo
        private void btnCrea_Click(object sender, EventArgs e)
        {
            pnlOperazioni.Enabled = true;
            flpMondo.Controls.Clear();
            btnRiga = Convert.ToInt32(Math.Sqrt(NUM));
            int dim = flpMondo.Width / btnRiga;

            mondo = new GameOfLife(btnRiga, btnRiga);
            for (int i = 0; i < btnRiga; i++)
                for (int j = 0; j < btnRiga; j++)
                {
                    Button b = new Button();
                    b.Name = $"{i}";
                    b.Tag = j;
                    b.Width = b.Height = dim - 1;
                    b.Margin = new Padding(0);
                    b.FlatStyle = FlatStyle.Standard;
                    b.BackColor = cGriglia;
                    b.Click += B_Click;
                    flpMondo.Controls.Add(b);
                    Application.DoEvents();
                }
            btnCrea.Enabled = false;
        }

        private void B_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(flag)
                B_Click(b, e);
        }

        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            mondo.AggiungiCella(Convert.ToInt32(b.Name), Convert.ToInt32(b.Tag));
            Controlla();
        }

        private void btnProssimo_Click(object sender, EventArgs e)
        {
            mondo.Prossimo();
            Controlla();
            txtGenerazioni.Text = (++con).ToString();
            veloce = trackBarVelocita.Value;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnStop.Enabled = false;
        }
        #endregion

        #region SchemiPredefiniti
        private void cmbSchemi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cella c;
            Azzera();
            listaCelle.Clear();
            int centro;
            if (btnRiga % 2 != 0)
                centro = btnRiga / 2 - 2;
            else
                centro = btnRiga / 2 - 1;
            switch (cmbSchemi.SelectedIndex)
            {
                case 0:
                    listaCelle.Add(c = new Cella(centro, centro));
                    listaCelle.Add(c = new Cella(centro, centro+1));
                    listaCelle.Add(c = new Cella(centro, centro-1));
                    break;
                case 1:
                    listaCelle.Add(c = new Cella(centro, centro));
                    listaCelle.Add(c = new Cella(centro+1, centro+1));
                    listaCelle.Add(c = new Cella(centro+2, centro+1));
                    listaCelle.Add(c = new Cella(centro+2, centro));
                    listaCelle.Add(c = new Cella(centro+2, centro-1));
                    break;
                case 2:
                    listaCelle.Add(c = new Cella(centro, centro));
                    listaCelle.Add(c = new Cella(centro-1, centro));
                    listaCelle.Add(c = new Cella(centro, centro+1));
                    listaCelle.Add(c = new Cella(centro, centro-1));
                    listaCelle.Add(c = new Cella(centro+1, centro+1));
                    listaCelle.Add(c = new Cella(centro+1, centro-1));
                    listaCelle.Add(c = new Cella(centro+2, centro));
                    break;
                case 3:
                    listaCelle.Add(c = new Cella(centro-2, centro));
                    listaCelle.Add(c = new Cella(centro-2, centro-2));
                    listaCelle.Add(c = new Cella(centro-2, centro+2));
                    listaCelle.Add(c = new Cella(centro-1, centro-2));
                    listaCelle.Add(c = new Cella(centro-1, centro+2));
                    listaCelle.Add(c = new Cella(centro, centro-2));
                    listaCelle.Add(c = new Cella(centro, centro+2));
                    listaCelle.Add(c = new Cella(centro+1, centro-2));
                    listaCelle.Add(c = new Cella(centro+1, centro+2));
                    listaCelle.Add(c = new Cella(centro+2, centro-2));
                    listaCelle.Add(c = new Cella(centro+2, centro+2));
                    listaCelle.Add(c = new Cella(centro+2, centro));
                    break;
                case 4:
                    listaCelle.Add(c = new Cella(centro, centro));
                    listaCelle.Add(c = new Cella(centro, centro-1));
                    listaCelle.Add(c = new Cella(centro, centro-2));
                    listaCelle.Add(c = new Cella(centro, centro-3));
                    listaCelle.Add(c = new Cella(centro, centro-4));
                    listaCelle.Add(c = new Cella(centro, centro-5));
                    listaCelle.Add(c = new Cella(centro, centro+1));
                    listaCelle.Add(c = new Cella(centro, centro+2));
                    listaCelle.Add(c = new Cella(centro, centro+3));
                    listaCelle.Add(c = new Cella(centro, centro+4));
                    break;
                case 5:
                    listaCelle.Add(c = new Cella(centro-2, centro-2));
                    listaCelle.Add(c = new Cella(centro-2, centro-1));
                    listaCelle.Add(c = new Cella(centro-2, centro+1));
                    listaCelle.Add(c = new Cella(centro-2, centro+2));

                    listaCelle.Add(c = new Cella(centro-1, centro-2));
                    listaCelle.Add(c = new Cella(centro-1, centro-1));
                    listaCelle.Add(c = new Cella(centro-1, centro+1));
                    listaCelle.Add(c = new Cella(centro-1, centro+2));

                    listaCelle.Add(c = new Cella(centro, centro-1));
                    listaCelle.Add(c = new Cella(centro, centro+1));

                    listaCelle.Add(c = new Cella(centro+1, centro-3));
                    listaCelle.Add(c = new Cella(centro+1, centro-1));
                    listaCelle.Add(c = new Cella(centro+1, centro+1));
                    listaCelle.Add(c = new Cella(centro+1, centro+3));

                    listaCelle.Add(c = new Cella(centro+2, centro-3));
                    listaCelle.Add(c = new Cella(centro+2, centro-1));
                    listaCelle.Add(c = new Cella(centro+2, centro+1));
                    listaCelle.Add(c = new Cella(centro+2, centro+3));

                    listaCelle.Add(c = new Cella(centro+3, centro-3));
                    listaCelle.Add(c = new Cella(centro+3, centro-2));
                    listaCelle.Add(c = new Cella(centro+3, centro+2));
                    listaCelle.Add(c = new Cella(centro+3, centro+3));
                    break;
            }
            mondo.Imposta(listaCelle);
            Controlla();
        }
        #endregion SchemiPredefiniti
        
        #region Velocita
        private void trackBarVelocita_Scroll(object sender, EventArgs e)
        {
            if (trackBarVelocita.Value > veloce)
                timer.Interval += 50;
            else if (trackBarVelocita.Value < veloce)
                timer.Interval -= 50;
        }

        private void cbxPiano_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPiano.Checked)
            {
                timer.Interval = 2000;
                trackBarVelocita.Enabled = false;
                cbxVeloce.Enabled = false;
            }
            else
            {
                cbxVeloce.Enabled = true;
                trackBarVelocita.Enabled = true;
                trackBarVelocita.Value = 5;
                timer.Interval = 500;
            }
        }

        private void cbxVeloce_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxVeloce.Checked)
            {
                timer.Interval = 1;
                trackBarVelocita.Enabled = false;
                cbxPiano.Enabled = false;
            }
            else
            {
                cbxPiano.Enabled = true;
                trackBarVelocita.Enabled = true;
                trackBarVelocita.Value = 5;
                timer.Interval = 500;
            }
        }
        #endregion

        #region Colore
        private void btnColorGriglia_Click(object sender, EventArgs e)
        {
            if (colorDialogGame.ShowDialog() == DialogResult.OK)
            {
                cGriglia = colorDialogGame.Color;
                btnColorGriglia.BackColor = cGriglia;
            }
            Controlla();
        }

        

        private void btnColorGame_Click(object sender, EventArgs e)
        {
            if (colorDialogGame.ShowDialog() == DialogResult.OK)
            {
                cGame = colorDialogGame.Color;
                btnColorGame.BackColor = cGame;
            }
            Controlla();
        }
        #endregion
    }
}
