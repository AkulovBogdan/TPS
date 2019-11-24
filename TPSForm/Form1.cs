using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TPSForm
{
    public partial class Form1 : Form
    {
        private List<FuelType> FuelTypeCollection { get; set; }

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            FuelTypeCollection = Enum.GetValues(typeof(FuelType)).Cast<FuelType>().ToList();

            foreach (var option in FuelTypeCollection)
            {
                cb_fuelSelect.Items.Add(option.ToString());
            }

            cb_fuelSelect.SelectedItem = cb_fuelSelect.Items[0];
        }

        public void TPSProcess(FuelType fuelType, double massOfFuelPerSecond, int workingTimeSeconds, double steamEfficiencyCoef, double turbineEfficiencyCoef)
        {
            Model model = new Model();

            var result = model.GetResultOfModel(fuelType, massOfFuelPerSecond, workingTimeSeconds, steamEfficiencyCoef, turbineEfficiencyCoef);

            result = result / 1_000_000;
            output.Items.Add($"{result} МДж");
        }

        private void numericUpDown3_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged_1(object sender, System.EventArgs e)
        {
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            var fuelType = FuelTypeCollection[cb_fuelSelect.SelectedIndex];
            var massOfFuelPerSecond = double.Parse(tb_fuelPerSecond.Text);
            var steamEfficiencyCoef = (double) nud_steamEfficiencyCoef.Value;
            var turbineEfficiencyCoef = (double) nud_turbineEfficiencyCoef.Value;
            var workingTimeSeconds = (int) nud_workTime.Value;

            TPSProcess(fuelType, massOfFuelPerSecond, workingTimeSeconds, steamEfficiencyCoef, turbineEfficiencyCoef);
        }
    }
}
