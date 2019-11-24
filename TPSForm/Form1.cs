using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPSForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Method();
        }

        public void Method()
        {
            Model model = new Model();

            double tmp = model.GetResultOfModel(FuelType.Coal, 86400, 0.35, 0.35);
            tmp = tmp / 1_000_000;
        }
    }
}
