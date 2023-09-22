using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Facciones_Continuas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(TxtNum1.Text);
            b = int.Parse(TxtNum2.Text);
            TbDatos.Rows.Clear();

            CalcularFraccionContinua(a, b);
        }

        private void CalcularFraccionContinua(int a, int b)
        {
            if (b == 0)
                return;

            int divi = a / b;
            int modu = a % b;

            string ecua;
            if (modu == 0)
            {
                ecua = a + "/" + b + " = " + divi;
            }
            else
            {
                ecua= a + "/" + b + " = " + divi + " + 1/" + b + " / " + modu;
            }

            TbDatos.Rows.Add(TbDatos.Rows.Count + 1, a + " dividido entre " + b + " es " + divi + " y sobran " + modu, ecua);

            CalcularFraccionContinua(b, modu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtNum1.Text = "";
            TxtNum2.Text = "";
            TbDatos.Rows.Clear();
        }
    }
}
