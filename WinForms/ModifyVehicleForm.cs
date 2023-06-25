using Vehicles;

namespace WinForms
{
    public partial class ModifyVehicleForm : Form
    {
        private Vehicle _vehicle;

        public ModifyVehicleForm(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;
        }

        private void ModifyVehicleForm_Load(object sender, EventArgs e)
        {
            type_Box.DataSource = Enum.GetValues(typeof(VehicleType));
            Apply(_vehicle);


            isLongRange_Box.Hide();
            if (_vehicle is not LongRangeVehicle)
            {
                meal_cost_label.Hide();
                meal_cost_Box.Hide();
            }
        }

        private void Configure_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public Vehicle GetModifiedVehicle()
        {
            _vehicle.AvarageSpeed = (int)avarage_speed_Box.Value;
            _vehicle.CostPerKilometer = (int)cost_per_km_Box.Value;
            _vehicle.Seats = (int)seats_Box.Value;
            _vehicle.OccupiedSeats = (int)occupied_seats_Box.Value;
            _vehicle.Type = (VehicleType)type_Box.SelectedValue;

            if (_vehicle is LongRangeVehicle lrVehicle)
            {
                int mealCost = (int)meal_cost_Box.Value;

                lrVehicle.MealCost = mealCost;
                _vehicle = lrVehicle;
            };

            return _vehicle;
        }

        private void Apply(Vehicle vehicle)
        {
            type_Box.SelectedIndex = (int)vehicle.Type;
            avarage_speed_Box.Value = vehicle.AvarageSpeed;
            cost_per_km_Box.Value = vehicle.CostPerKilometer;
            seats_Box.Value = vehicle.Seats;
            occupied_seats_Box.Value = vehicle.OccupiedSeats;

            if (vehicle is LongRangeVehicle lrVehicle)
                meal_cost_Box.Value = lrVehicle.MealCost;
        }

        private void seats_Box_ValueChanged(object sender, EventArgs e)
        {
            occupied_seats_Box.Maximum = seats_Box.Value;
        }
    }
}
