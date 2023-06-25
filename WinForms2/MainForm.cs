using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Vehicles;

namespace WinForms2
{
    public partial class MainForm : Form
    {
        private BindingList<Vehicle> _vehicles = new BindingList<Vehicle>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = _vehicles;
        }

        private void Import_Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var list = VehicleSerializer.DeserializeFromFile(openFileDialog1.FileName);
                foreach (var vehicle in list)
                {
                    _vehicles.Add(vehicle);
                }
            }
        }

        private void New_Vehicle_Button_Click(object sender, EventArgs e)
        {
            ConfigurateVehicleForm form = new ConfigurateVehicleForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                _vehicles.Add(form.GetVehicle());
            }
        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
