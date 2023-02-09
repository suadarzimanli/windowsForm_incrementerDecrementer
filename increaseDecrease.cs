using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        } 

        int number = 0; //Bu global alan kod calisdiginda halen disarda oldugu icin sayi devam eder

        private void btnClick_Click(object sender, EventArgs e)
        {
            //int number = 0; bu ise local alandir kod bir kere calisdikdan sonra bitmisdir cunki hayati bu cemberin icindedir
            MessageBox.Show((++number).ToString());
        }

        private void btnClick2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((--number).ToString());
        }
    }
}
