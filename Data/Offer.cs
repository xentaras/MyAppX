using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class Offer
    {
        private Answers m_Answers;
        

        public Offer(Answers answers)
        {
            m_Answers = answers;
            SelectInitialProducts(SelectBundle());
        }

        public IProduct[] Accounts =>
            new IProduct[]
            {
                new CurrentAccount(),
                new CurrentAccountPlus(),
                new JuniorSaverAccount(),
                new StudentAccount()
            };

        public IProduct[] CreditCards =>
            new IProduct[]
            {
                new DebitCard(),
                new CreditCard(),
                new GoldCreditCard()
            };

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

            return allBundles.
                Where(i => i.IsApplicable).
                Aggregate((agg, next) =>
                    next.Value > agg.Value ? next : agg);
        }

        private void SelectInitialProducts(IBundleTemplate initialBundle)
        {
            Accounts.Single(i => initialBundle.TemplateAccount == i.GetType()).IsSelected = true;

            foreach (var creditCard in 
                CreditCards.Where(i => initialBundle.TemplateCreditCards.Contains(i.GetType())))
            {
                creditCard.IsSelected = true;
            }
        }
    }
}
