using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Döviz_Ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lbldolaralis.Text = dolaralis;
            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lbldolarsatıs.Text = dolarsatis; 

            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleuroalıs.Text = euroalis;
            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleurosatıs.Text = eurosatis;
        }

        private void btndolaral_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolaralis.Text;
            txtkur.Enabled = false;
            
        }

        private void btndolarsat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbldolarsatıs.Text;
            txtkur.Enabled = false;
        }

        private void btneuroal_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleuroalıs.Text;
            txtkur.Enabled = false;
        }

        private void btneurosat_Click(object sender, EventArgs e)
        {
            txtkur.Text = lbleurosatıs.Text;
            txtkur.Enabled = false;
        }

        private void btnsatısyap_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(txtkur.Text);
            miktar = Convert.ToDouble(txtmiktar.Text);
            tutar = kur * miktar;
            txttutar.Text = tutar.ToString();
        }

        private void txtkur_TextChanged(object sender, EventArgs e)
        {
            txtkur.Text = txtkur.Text.Replace(".", ","); //Replace özelliği istediğimiz karakteri değiştirmemizi sağlar. Burada . gördüğün yerlere , yaz diyoruz.
        }

        private void btntutar_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(txtkur.Text);
            int tutar = Convert.ToInt32(txttutar.Text);
            int miktar = Convert.ToInt32(tutar/kur);
            txtmiktar.Text = miktar.ToString();
            int kalan;
            kalan = Convert.ToInt32(tutar%kur);
            txtkalan.Text = kalan.ToString();


        }
    }
}
