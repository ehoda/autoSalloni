using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalloni
{
    public partial class Form1 : Form
    {
        List<CarDetails> Cars = new List<CarDetails>();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTransmission_Click(object sender, EventArgs e)
        {

        }

        private void lblSeats_Click(object sender, EventArgs e)
        {

        }

        private void lblDoors_Click(object sender, EventArgs e)
        {

        }

        private void lblColour_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            cbFirma.SelectedIndex = -1;
            cbYear.SelectedIndex = -1;
            cbTransmission.SelectedIndex = -1;
            cbColour.SelectedIndex = -1;
            txtModel.Text = "";
            txtDoors.Text = "";
            txtSeats.Text = "";
            txtKm.Text = "";
            dtpDate.Value = DateTime.Today;
        }

        private void lblFirma_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarDetails car = Cars[lbCarDetails.SelectedIndex];
            cbFirma.SelectedItem = car.Firma;
            cbYear.SelectedItem = car.Year.ToString();
            cbTransmission.SelectedIndex = car.IsAutomaticTransmission ? 0 : 1;
            cbColour.SelectedItem = car.Colour;
            txtModel.Text = car.Model;
            txtDoors.Text = car.Doors.ToString();
            txtSeats.Text = car.Seats.ToString();
            txtKm.Text = car.Km.ToString();
            dtpDate.Value = car.DateOfSale;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CarDetails car = new CarDetails();
            car.Firma = cbFirma.SelectedItem.ToString();
            car.Year = Convert.ToInt32(cbYear.SelectedItem.ToString());
            car.Model = txtModel.Text;
            car.DateOfSale = dtpDate.Value;
            car.IsAutomaticTransmission = cbTransmission.SelectedItem.ToString() == "AUTOMATIC";
            car.Seats = Convert.ToInt32(txtSeats.Text);
            car.Km = Convert.ToInt32(txtKm.Text);
            car.Doors = Convert.ToInt32(txtDoors.Text);
            car.Colour = cbColour.SelectedItem.ToString();

            int carIndex = Cars.FindIndex(c => c.Firma == car.Firma && c.Model == car.Model && c.Year == car.Year && c.Km == car.Km);

            if (carIndex == -1)
            {
                Cars.Add(car);
                lbCarDetails.Items.Add(car.convertObjectToString());
            }
            else
            {
                Cars[carIndex] = car;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbCarDetails.SelectedIndex > -1)
            {
                Cars.RemoveAt(lbCarDetails.SelectedIndex);
                lbCarDetails.Items.RemoveAt(lbCarDetails.SelectedIndex);
            }
        }
    }
}
