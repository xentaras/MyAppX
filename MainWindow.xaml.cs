using MyApp.ViewModel;
using MyApp.Views;
using System;
using System.Linq;
using System.Windows;

namespace MyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private QuestionsView m_QuestionsView;
        private OfferingView m_OfferingView;

        public MainWindow()
        {
            InitializeComponent();
            Init();     
        }

        private void Init()
        {
            m_QuestionsView = new QuestionsView();
            var viewModel = new QuestionsViewModel();
            viewModel.OnConfirmed += QuestionsAnswered;
            m_QuestionsView.DataContext = viewModel;
            MyContent.Children.Add(m_QuestionsView);
        }

        private void QuestionsAnswered(object sender, EventArgs e)
        {
            var questionsVieModel = (QuestionsViewModel)sender;

            if (!string.IsNullOrEmpty(questionsVieModel.ErrorString))
            {
                MessageBox.Show(questionsVieModel.ErrorString);
                return;
            }

            m_OfferingView = new OfferingView();
            var viewModel = new OfferingViewModel();
            viewModel.OnConfirmed += OfferSelected;
            m_OfferingView.DataContext = viewModel;
            viewModel.Init(questionsVieModel.Answers);

            MyContent.Children.Remove(m_QuestionsView);
            MyContent.Children.Add(m_OfferingView);           
        }

        private void OfferSelected(object sender, EventArgs e)
        {
            var offeringViewModel = ((OfferingViewModel)sender);

            var selectedAccount = offeringViewModel.Accounts.SingleOrDefault(i => i.IsSelected);
            var selectedCards = offeringViewModel.CreditCards.Where(i => i.IsSelected);

            var accountsString = string.Empty;
            var cardsString = string.Empty;
            if (selectedAccount != null)
                accountsString = string.Format(Strings.SelectedAcount, selectedAccount.Name);
            else
                accountsString = Strings.NoSelectedAccount;

            if (selectedCards.Any())
                cardsString = string.Format(Strings.SelectedCards, String.Join(", ", selectedCards.Select(i => i.Name).ToArray()));
            else
                cardsString = Strings.NoSelectedCards;

            MessageBox.Show($"{accountsString}{Environment.NewLine}{cardsString}");
        }
    }
}
