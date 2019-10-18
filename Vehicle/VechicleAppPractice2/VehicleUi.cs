using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {

        public Vehicle Vehicle;
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Vehicle  = new Vehicle(vehicleNameTextBox.Text,Convert.ToInt32(regNoTextBox.Text));
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Vehicle.speed.Add(Convert.ToDouble(speedTextBox.Text));
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            maxSpeedTextBox.Text = Vehicle.speed.Max().ToString();
            minSpeedTextBox.Text = Vehicle.speed.Min().ToString();
            averageSpeedTextBox.Text = Vehicle.speed.Average().ToString();
        }
    }
}
