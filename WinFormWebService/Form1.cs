using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormWebService
{
    public partial class frm_vatandasSorgu : Form
    {
        public frm_vatandasSorgu()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            /*
             Bilindiği üzere web servisler HTTP PROTOCOLleri ile çalışırlar.
            Client bir request(istek) atar; neticesinde de bir response (geri dönüş) olur.
            Ve bu geri dönüşte de JSON XML gibi yapılar kullanırlar.

            Bu öreneğimizde de text boxtan alınan verileri sorgulayıp
            geri dönüş değeri olarak bool bir veri döndürdük.

           
             
             */

            long kimlikNo=long.Parse(txt_tcNo.Text);
            int dogumYili = int.Parse(txt_dogumYili.Text);
            int yil=int.Parse(txt_dogumYili.Text);
            bool durum;

            try
            {
                using (TcDogrula.KPSPublicSoapClient service=new TcDogrula.KPSPublicSoapClient())
                {
                    durum = service.TCKimlikNoDogrula(kimlikNo, textBox2.Text, txt_soyisim.Text, dogumYili);
                }
            }
            catch (Exception)
            {
                throw;
            }

            string msg = durum==true?"Aradığınız kişi sistemde mecvuttur.":"Aradığınız kişi sistemde mecvut değildir.";
            
            MessageBox.Show(msg);
        }
    }
}
