using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma_set_y_get
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sumaclass sum = new Sumaclass();

            sum.N11=int.Parse(textBox1.Text);
            sum.N12=int.Parse(textBox2.Text);

            textBox3.Text=sum.Suma().ToString();
        }
    }
}
