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
    public partial class formKategoria : Form
    {
        
        public formKategoria()
        {
            InitializeComponent();
            
        }

        private void formKategoria_Load(object sender, EventArgs e)
        {
            btnTevekenyseg.FlatAppearance.BorderSize = 0;
            btnID.FlatAppearance.BorderSize = 0;
            btnIdo.FlatAppearance.BorderSize = 0;
            btnSzereplo.FlatAppearance.BorderSize = 0;

            btnBezar.FlatAppearance.BorderSize = 0;
            btnTovabb.FlatAppearance.BorderSize = 0;
        }
    }
}
