using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PohybPoDraze
{
    public partial class CarAdd : Form
    {
        public Form1 Form1 { get; set; }
        public CarAdd(Form1 form1)
        {
            Form1 = form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => Form1.AddCar(new Car(new Point(100, 150), (int)numericUpDown1.Value, listBox1.SelectedItem.ToString()));
    }
}
