using PropertyChanged;

namespace BMI.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Metrics
    {
        public float Height { get; set; }
        public float Weight { get; set; }
        public float Result => ((Weight / Height) / Height) * 10_000;
        public string ResultText => Result switch
        {
            <=16 => "Muy delgado",
            >16 and <=17 => "Moderado",
            >17 and <=18.5f => "Delgado",
            >18.5f and <=25 => "Normal",
            >25 and <=30 => "Obesidad",
            >30 and <=35 => "Obesidad Clase I",
            >35 and <=40 => "Obesidad Clase II",
            >40 => "Obesidad Clase III",
            _ => "No calculado"
        };
    }
}