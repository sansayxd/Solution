using Vehicles;

namespace WinForms
{
    public partial class ConfigureVehicleForm : Form
    {
        public ConfigureVehicleForm()
        {
            InitializeComponent();
        }

        private void ConfigureVehicleForm_Load(object sender, EventArgs e)
        {
            type_Box.DataSource = Enum.GetValues(typeof(VehicleType));
            meal_cost_label.Hide();
            meal_cost_Box.Hide();
        }

        private void Configure_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public Vehicle GetConfiguredVehicle()
        {
            bool isLongRange = isLongRange_Box.Checked;
            VehicleType type = (VehicleType)type_Box.SelectedValue;
            int avarageSpeed = (int)avarage_speed_Box.Value;
            int costPerKilometer = (int)cost_per_km_Box.Value;
            int seats = (int)seats_Box.Value;
            int occupiedSeats = (int)occupied_seats_Box.Value;

            Vehicle vehicle;

            if (!isLongRange)
            {
                vehicle = new Vehicle
                {
                    AvarageSpeed = avarageSpeed,
                    CostPerKilometer = costPerKilometer,
                    Seats = seats,
                    OccupiedSeats = occupiedSeats,
                    Type = type,
                };
            }
            else
            {
                int mealCost = (int)meal_cost_Box.Value;
                vehicle = new LongRangeVehicle
                {
                    AvarageSpeed = avarageSpeed,
                    CostPerKilometer = costPerKilometer,
                    Seats = seats,
                    OccupiedSeats = occupiedSeats,
                    Type = type,
                    MealCost = mealCost,
                };
            }

            return vehicle;
        }

        private void seats_Box_ValueChanged(object sender, EventArgs e)
        {
            occupied_seats_Box.Maximum = seats_Box.Value;
        }

        private void isLongRange_Box_CheckedChanged(object sender, EventArgs e)
        {
            if (isLongRange_Box.Checked)
            {
                meal_cost_label.Show();
                meal_cost_Box.Show();
            }
            else
            {
                meal_cost_label.Hide();
                meal_cost_Box.Hide();
            }
        }
    }
}
