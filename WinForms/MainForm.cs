using System.ComponentModel;
using System.Linq.Expressions;
using System.Data.Common;
using System.Windows.Forms;
using Vehicles;

namespace WinForms
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
            dataGridView.SelectionChanged += UpdateSelectedLabel;
            dataGridView.RowsAdded += UpdateCountLabel;
            dataGridView.RowsRemoved += UpdateCountLabel;
        }

        private void Import_Button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a File";
            openFileDialog1.Filter = "All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                var vehicles = VehicleSerializer.DeserializeFromFile(selectedFilePath);
                foreach (Vehicle vehicle in vehicles)
                    _vehicles.Add(vehicle);
            }
        }

        private void Export_Button_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Select a File";
            saveFileDialog1.Filter = "All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = saveFileDialog1.FileName;

                VehicleSerializer.SerializeToFile(_vehicles.ToArray(), selectedFilePath);
            }
        }

        private void Configure_New_Button_Click(object sender, EventArgs e)
        {
            ConfigureVehicleForm configureVehicleForm = new ConfigureVehicleForm();
            configureVehicleForm.ShowDialog();

            if (configureVehicleForm.DialogResult == DialogResult.OK)
            {
                Vehicle newVehicle = configureVehicleForm.GetConfiguredVehicle();
                _vehicles.Add(newVehicle);
            }
        }

        private void Modify_Selected_Button_Click(object sender, EventArgs e)
        {
            var vehicle = GetSelectedVehicle();
            if (vehicle is null)
                return;

            ModifyVehicleForm modifyVehicleForm = new ModifyVehicleForm(vehicle);
            modifyVehicleForm.ShowDialog();

            if (modifyVehicleForm.DialogResult == DialogResult.OK)
            {
                _vehicles.Remove(vehicle);
                Vehicle newVehicle = modifyVehicleForm.GetModifiedVehicle();
                _vehicles.Add(newVehicle);
                Select(newVehicle);
            }
        }

        private void Clear_All_Button_Click(object sender, EventArgs e)
        {
            _vehicles.Clear();
        }

        private void Clear_Selected_Button_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView.SelectedRows;
            if (selectedRows.Count <= 0)
                return;

            foreach (DataGridViewRow row in selectedRows)
                _vehicles.Remove((Vehicle)row.DataBoundItem);
        }

        private void Select_Largest_Button_Click(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
            var largest = _vehicles.Max();
            if (largest is null)
                return;

            Select(largest);
        }

        private void Select_Cheapest_Button_Click(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
            Vehicle? cheapest = _vehicles.MinBy(x => x.GetCost((int)Distance_Box.Value));
            if (cheapest is null)
                return;

            Select(cheapest);
        }

        private void Type_Of_Selected_Button_Click(object sender, EventArgs e)
        {
            var vehicle = GetSelectedVehicle();
            if (vehicle is null)
                return;

            MessageBox.Show(vehicle.GetType().ToString(), 
                "Type of selected vehicle: ", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Get_Cost_Button_Click(object sender, EventArgs e)
        {
            var vehicle = GetSelectedVehicle();
            if (vehicle is null)
                return;

            int distance = (int)Distance_Box.Value;
            MessageBox.Show(vehicle.GetCost(distance).ToString(),
                    $"Cost to travel {distance} on {vehicle.Type}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void Selected_Info_Button_Click(object sender, EventArgs e)
        {
            var vehicle = GetSelectedVehicle();
            if (vehicle is null)
                return;

            MessageBox.Show(vehicle.GetImage(),
                    "Vehicle info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void UpdateCountLabel(object? sender, EventArgs e)
        {
            count_label.Text = "Vehicles count: " + _vehicles.Count;
        }

        private void UpdateSelectedLabel(object? sender, EventArgs e)
        {
            selected_label.Text = "Selected vehicles: " + dataGridView.SelectedRows.Count;
        }

        private void aboutAuthor_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by AAAAAAAA AAAAAAA",
                "About author",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void aboutProgram_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 0.00.00.1", 
                "About program",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void OnAllSeatsOccupied(Vehicle sender)
        {
            MessageBox.Show("All seats are occupied in the vehicle: " + sender.GetImage(),
                "Seats occupied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Subscribe_Button_Click(object sender, EventArgs e)
        {
            foreach (var vehicle in _vehicles)
            {
                vehicle.AllSeatsOccupied -= OnAllSeatsOccupied;
            }

            foreach (var vehicle in _vehicles)
            {
                vehicle.AllSeatsOccupied += OnAllSeatsOccupied;
            }
        }

        private Vehicle? GetSelectedVehicle()
        {
            var selectedRows = dataGridView.SelectedRows;
            if (selectedRows.Count <= 0)
                return null;

            if (selectedRows.Count > 1)
            {
                MessageBox.Show("Multiple vehicles selected",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return null;
            }

            return (Vehicle)selectedRows[0].DataBoundItem;
        }

        private void Select(Vehicle vehicle)
        {
            int index = _vehicles.IndexOf(vehicle);
            dataGridView.Rows[index].Selected = true;
        }
    }
}