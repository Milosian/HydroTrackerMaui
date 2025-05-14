namespace HydroTrackerMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("AddPortionWater", typeof(AddPortionWaterPage));
        }
    }
}
