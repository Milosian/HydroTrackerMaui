namespace HydroTrackerMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            HydrationData data = new HydrationData();
            WaterConsumedLbl.Text = data.amountOfConsumedWater.ToString() + " ml";
            DailyTargetLbl.Text = $"{data.dailyTargetPercent}%";
        }
    }

}
