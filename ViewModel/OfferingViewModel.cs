using MyApp.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MyApp.ViewModel
{
    public class OfferingViewModel : ViewModelBase
    {
        private Answers m_Answers;

        public event EventHandler OnConfirmed;

        public OfferingViewModel()
        {
            
        }

        public void Init(Answers answers)
        {
            m_Answers = answers;      
            Accounts = new ObservableCollection<Product>()
            {
                new CurrentAccount(),
                new CurrentAccountPlus(),
                new JuniorSaverAccount(),
                new StudentAccount()
            };
            CreditCards = new ObservableCollection<Product>()
            {
                new DebitCard(),
                new CreditCard(),
                new GoldCreditCard()
            };

            var initialBundle = SelectBundle();

            if (initialBundle != null)
                SelectInitialProducts(initialBundle);
            else
                Recheck();

            foreach (var account in Accounts)
                account.PropertyChanged += AccountPropertyChanged;
        }

        private void AccountPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Product.IsSelected))
                Recheck();
        }

        private ObservableCollection<Product> m_Accounts;
        public ObservableCollection<Product> Accounts
        {
            get => m_Accounts;
            set
            {
                if (m_Accounts != value)
                {
                    m_Accounts = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<Product> m_CreditCards;
        public ObservableCollection<Product> CreditCards
        {
            get => m_CreditCards;
            set
            {
                if (m_CreditCards != value)
                {
                    m_CreditCards = value;
                    NotifyPropertyChanged();
                }
            }
        }
            

        private IBundleTemplate SelectBundle()
        {
            var allBundles = new IBundleTemplate[]
            {
                new JuniorSaverBundle(m_Answers),
                new StudentBundle(m_Answers),
                new ClassicBundle(m_Answers),
                new ClassicPlusBundle(m_Answers),
                new GoldBundle(m_Answers)
            };

            if (!allBundles.Any(i => i.IsApplicable))
                return null;

            return allBundles.
                Where(i => i.IsApplicable).
                Aggregate((agg, next) =>
                    next.Value > agg.Value ? next : agg);
        }

        private void SelectInitialProducts(IBundleTemplate initialBundle)
        {
            foreach (var account in Accounts)
            {
                account.CheckIfApplicable(m_Answers, Accounts);
                if (initialBundle.TemplateAccount == account.GetType() && account.IsApplicable == true)
                    account.IsSelected = true;
            }

            foreach (var creditCard in CreditCards)
            {
                creditCard.CheckIfApplicable(m_Answers, Accounts);
                if (initialBundle.TemplateCreditCards.Any(i => i == creditCard.GetType()) && creditCard.IsApplicable == true)
                    creditCard.IsSelected = true;
            }
        }

        public void Recheck()
        {
            foreach (var account in Accounts)
                account.CheckIfApplicable(m_Answers, Accounts);

            foreach (var creditCard in CreditCards)
                creditCard.CheckIfApplicable(m_Answers, Accounts);
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
            OnConfirmed?.Invoke(this, null);
        }
    }
}
