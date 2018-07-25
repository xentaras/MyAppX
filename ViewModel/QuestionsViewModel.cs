using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyApp.ViewModel
{
    class QuestionsViewModel : ViewModelBase
    {
        public event EventHandler OnConfirmed;

        private int? m_Age;
        public int? Age
        {
            get => m_Age;
            set
            {
                if (m_Age != value)
                {
                    m_Age = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private decimal? m_Income;
        public decimal? Income
        {
            get => m_Income;
            set
            {
                if (m_Income != value)
                {
                    m_Income = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool? m_NotStudent;
        public bool? NotStudent
        {
            get => m_NotStudent;
            set
            {
                if (m_NotStudent != value)
                {
                    m_NotStudent = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool? m_IsStudent;
        public bool? IsStudent
        {
            get => m_IsStudent;
            set
            {
                if (m_IsStudent != value)
                {
                    m_IsStudent = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private ICommand m_ConfirmCommand;
        public ICommand ConfirmCommand
        {
            get
            {
                return m_ConfirmCommand ?? 
                    (m_ConfirmCommand = new CommandHandler(() => Confirm(), true));
            }
        }

        private void Confirm()
        {
            if (Age != null && Income != null)
            {
                Confirmed();
            }
            else
            {

            }
        }

        private void Confirmed()
        {
            OnConfirmed?.Invoke(this, null);
        }
    }
}
