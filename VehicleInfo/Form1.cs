namespace VehicleInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ShowInfo_Click(object sender, EventArgs e)
        {
            string vehicleBrand;
            string vehicleYear;

            Vehicle? vehicle = null;

            if (cmb_Vehicles.SelectedItem.ToString() == "Car")
                vehicle = new Car();
            else if (cmb_Vehicles.SelectedItem.ToString() == "Truck")
                vehicle = new Truck();
            else if (cmb_Vehicles.SelectedItem.ToString() == "Motorcycle")
                vehicle = new Motorcycle();

            if (vehicle != null)
            {
                vehicleBrand = vehicle.DisplayInfo()[0];
                vehicleYear = vehicle.DisplayInfo()[1];

                lbl_Brand.Text = vehicleBrand;
                lbl_Year.Text = vehicleYear;
            }
            else
            {
                MessageBox.Show("vehicle is null");
            }

        }
    }
}
