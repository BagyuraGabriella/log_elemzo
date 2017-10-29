using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogElemzo
{
    public partial class formBelepes : Form
    {
        public string nev;
        public string jelszo;

        public formBelepes()
        {
            InitializeComponent();
        }

        private void formBelepes_Load(object sender, EventArgs e)
        {
            txtNev.Text = "Felhasználónév";
            txtJelszo.Text = "Jelszó";

            txtNev.ForeColor = Color.Gray;
            txtJelszo.ForeColor = Color.Gray;

            btnBelep.FlatAppearance.BorderSize = 0;
            btnKilep.FlatAppearance.BorderSize = 0;
        }

        private void txtNev_Click(object sender, EventArgs e)
        {
            if (txtNev.Text == "Felhasználónév")
            {
                txtNev.Text = "";
            }
            if(txtJelszo.Text == "")
            {
                txtJelszo.Text = "Jelszó";
                txtJelszo.PasswordChar = '\0';
            }
        }

        private void txtJelszo_Click(object sender, EventArgs e)
        {
            if (txtJelszo.Text == "Jelszó")
            {
                txtJelszo.PasswordChar = (char)0x2022;
                txtJelszo.Text = "";
            }
            if(txtNev.Text == "")
            {
                txtNev.Text = "Felhasználónév";
            }
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBelep_Click(object sender, EventArgs e)
        {
            if(txtNev.Text == "asd" & txtJelszo.Text == "1234")
            {

                formBeolvas fb = new formBeolvas();
                this.Hide();
                fb.Show();
            } else
            {
                MessageBox.Show(txtJelszo.Text);
                MessageBox.Show("Rossz felhasználónév vagy jelszó!");
                txtJelszo.Clear();
                txtJelszo.Text = String.Empty;
            }
        }

        private void txtNev_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyData == Keys.Tab)
            {
                txtJelszo_Click(sender, e);
            }
        }

        private void txtJelszo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btnBelep_Click(sender,e);
            }
        }
    }
}
