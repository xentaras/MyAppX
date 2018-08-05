using MyApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public abstract class Product : ViewModelBase
    {
        private bool m_IsApplicable = false;
        public bool IsApplicable
        {
            get => m_IsApplicable;
            set
            {
                if (m_IsApplicable != value)
                {
                    m_IsApplicable = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string m_WhyNot = string.Empty;
        public string WhyNot
        {
            get => m_WhyNot;
            set
            {
                if (m_WhyNot != value)
                {
                    m_WhyNot = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool m_IsSelected = false;
        public bool IsSelected
        {
            get => m_IsSelected;
            set
            {
                if (m_IsSelected != value)
                {
                    m_IsSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Name => GetName();

        public abstract void CheckIfApplicable(Answers answers, IEnumerable<Product> accounts);

        protected abstract string GetName();
    }
}
