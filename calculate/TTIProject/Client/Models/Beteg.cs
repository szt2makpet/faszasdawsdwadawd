using System.ComponentModel;
using ViewModels.BaseClass;

namespace TTIProject.Model
{
    public class Beteg : ViewModelBase
    {
        /// <summary>
        /// Beteg súlya (kg)
        /// </summary>
        private double _aoldal;
        /// <summary>
        /// Beteg magassága (méter)
        /// </summary>
        private double _boldal;

        /// <summary>
        /// Alapértelmezett konstruktor
        /// </summary>
        public Beteg()
        {
            _aoldal = 0;
            _boldal = 0;
        }

        /// <summary>
        /// Írható tulajdonságok
        /// </summary>

        public string Aoldal
        {
            get => _aoldal.ToString();
            set => SetValue(ref _aoldal, Convert.ToDouble(value));
        }

        public string Boldal
        {
            get => _boldal.ToString();
            set => SetValue(ref _boldal, Convert.ToDouble(value));
        }

        /// <summary>
        /// Olvasható tulajdonságok
        /// Testtömeg index: kg / magasság^2
        /// </summary>
        public double teglalapEredmeny
        {
            get
            {
                double teglalapEredmeny = _aoldal* _boldal;
                double kerekites = Math.Round(teglalapEredmeny, 2);
                return kerekites;
            }
        }

        public string BetegAdatok
        {
            get
            {
                return " téglalap terúlete: " + teglalapEredmeny;
            }
        }

        public void Compute()
        {
            OnPropertyChanged(nameof(teglalapEredmeny));
        }
    }
}
