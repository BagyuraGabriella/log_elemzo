using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;
using ExcelDataReader;

namespace LogElemzo
{
    public partial class formBeolvas : Form
    {
        bool beolvas = false;
        bool valaszt = false;
        public formBeolvas()
        {
            InitializeComponent();
        }

        DataSet result;

        private void formBeolvas_Load(object sender, EventArgs e)
        {
            btnMegnyit.FlatAppearance.BorderSize = 0;
            btnTovabb.FlatAppearance.BorderSize = 0;
            btnBezar.FlatAppearance.BorderSize = 0;

            cboxModszer.Items.Add(" - módszer választás -");
            cboxModszer.Items.Add("Dolgozók teljesítménye leterheltség függvényében.");
            cboxModszer.Items.Add("Hétvégi és hétfői műszakok közti különbség.");
            cboxModszer.Items.Add("Délelőttös és délutáni műszakok közti különbég.");

            cboxModszer.SelectedIndex = 0;
        }

        private void btnMegnyit_Click(object sender, EventArgs e)
        {
            //Exel97-2003 formátumba lementett fájlal működik
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook 97-2003|*.xls|Excel Workbook|*.xlsx", ValidateNames = true})
            {
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader;

                    if (ofd.FilterIndex==1)
                    {
                        reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    } else
                    {
                        reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                    }
                    beolvas = true;
                    result = reader.AsDataSet();
                    reader.Close();
                    dgvLOG.DataSource = result.Tables[0];
                } else
                {
                    beolvas = false;
                }
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTovabb_Click(object sender, EventArgs e)
        {
            if(beolvas == true & valaszt == true)
            {
                formKategoria fk = new formKategoria();

                this.Hide();
                fk.Show();
            } else
            {
                MessageBox.Show("Nincs kiválasztva fájl, vagy elemzési módszer!");
            }
           
        }

        private void cboxModszer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboxModszer.SelectedIndex < 1)
            {
                valaszt = false;
            } else
            {
                valaszt = true;
            }
        }
    }
}
