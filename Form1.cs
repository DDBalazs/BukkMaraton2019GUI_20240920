using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukkMaraton2019GUI_20240920
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {
            vbtav.Text = "Közép - 57km";
            txido.Text = "1:00:00";
            lbkm.Visible = false;
            lbm.Visible = false;
        }

        private void btszamol_Click(object sender, EventArgs e)
        {
            double kmo = 0;
            double ms = 0;
            double tav = 0;
            double ido = Convert.ToDouble(txido.Text);
            if (vbtav.SelectedIndex == 0)
            {
                tav = 16;
            }
            else if (vbtav.SelectedIndex == 1) { tav = 38; }
            else if (vbtav.SelectedIndex == 2) { tav = 54; }
            else if (vbtav.SelectedIndex == 3) { tav = 57; }
            else if (vbtav.SelectedIndex == 4) { tav = 94; }


            kmo = tav / ido;
            lbkm.Text = kmo.ToString();

            ms = tav * 1000 / ido * 3600;
            lbm.Text = ms.ToString();
            lbkm.Visible = true;
            lbm.Visible = true;
        }
    }
}
