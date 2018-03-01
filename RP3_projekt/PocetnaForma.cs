using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP3_projekt
{
    public partial class PocetnaForma : Form
    {
        #region Load

        public PocetnaForma()
        {
            InitializeComponent();
            this.richTextBox1.Visible = false;
        }

        private void PocetnaForma_Load(object sender, EventArgs e) {

        }

        #endregion

        #region Buttoni

        // Button 'Zaposlenici'
        private void button1_Click(object sender, EventArgs e)
        {
            FormaZaposlenici form1 = new FormaZaposlenici();
            form1.ShowDialog();
        }

        // Button 'Vozila'
        private void button2_Click(object sender, EventArgs e)
        {
            FormaVozila form2 = new FormaVozila();
            form2.ShowDialog();
        }

        // Button 'Servisi'
        private void button4_Click(object sender, EventArgs e) {
            FormaServisa form3 = new FormaServisa();
            form3.ShowDialog();
        }

        // Button 'Podaci o tvrtci'
        private void button3_Click(object sender, EventArgs e) {
            if (!this.richTextBox1.Visible) {
                this.richTextBox1.Text = "Tvrtka: AutoServis d.o.o.\nOIB: 0123456789\nAdresa: Bijenička cesta 30a, 10000 Zagreb";
                this.richTextBox1.Visible = true;
            } else {
                this.richTextBox1.Visible = false;
            }
        }

        #endregion        
    }
}
