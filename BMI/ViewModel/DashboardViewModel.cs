using BMI.Models;

namespace BMI.ViewModel
{
    public class DashboardViewModel
    {
        public Metrics Metrics { get; set; }

        public DashboardViewModel()
        {
            Metrics = new Metrics()
            {
                Height = 178,
                Weight = 84
            };
        }
    }
}