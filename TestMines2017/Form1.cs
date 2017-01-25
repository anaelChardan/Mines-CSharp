using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMines2017.monWS;

namespace TestMines2017
{
    public partial class TestEMN2017 : Form
    {
        public TestEMN2017()
        {
            InitializeComponent();
        }

        private void btn_quote_Click(object sender, EventArgs e)
        {
            monWS.DelayedStockQuote MWS = new DelayedStockQuote();
            monWS.QuoteData QD;
            QD = MWS.GetQuote(code_action_text_box.Text, "0");
            label_resultat.Text = "Le cours de l'action " + QD.CompanyName + " est de :" + QD.LastTradeAmount.ToString();
        }
    }
}
