using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BitcoinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currencyselector.SelectedItem.ToString() == "EUR" || currencyselector.SelectedItem.ToString() == "EEK")
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                if (currencyselector.SelectedItem.ToString() == "EEK")
                {
                    result *= (float)(15.6466);
                    resultlabel.Text = $"{result} Bitcoini eesti kroonides";
                }
                else
                {
                    resultlabel.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.EUR.code}";
                }
            }
            /*
             Lisate juurde Dollari, naela ja eesti krooni.
             */
            if (currencyselector.SelectedItem.ToString() == "GBP" )
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                resultlabel.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.GBP.code}";
            }
            if (currencyselector.SelectedItem.ToString() == "USD" )
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Bpi.EUR.rate_float;
                resultlabel.Text = $"{result} Bitcoini {newbitcoinrate.Bpi.GBP.code}";
            }
        }

        public static BitcoinRates GetRates()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return bitcoin;
        }
    }
}
