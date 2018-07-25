using MyApp.ViewModel;
using MyApp.Views;
using System;
using System.Windows;

namespace MyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private QuestionsView m_QuestionsView;

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
            Content.Children.Add(m_QuestionsView);
        }

        private void QuestionsAnswered(object sender, EventArgs e)
        {
            var view = new OfferingView();
            var viewModel = new OfferingViewModel();
            view.DataContext = viewModel;

            Content.Children.Remove(m_QuestionsView);

            Content.Children.Add(view);
        }
    }
}
