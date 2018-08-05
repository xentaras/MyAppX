using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class DebitCard : Product 
    {
        public DebitCard()
        {
            
        }

        protected override string GetName() => Strings.DebitCard;

        public override void CheckIfApplicable(Answers answers, IEnumerable<Product> accounts)
        {
            IsApplicable =
                accounts.Where(i => i.GetType() != typeof(JuniorSaverAccount)).Any(i => i.IsSelected == true);

            if (IsApplicable != true)
                WhyNot = Strings.MustSelectAccount;
            else
                WhyNot = Name;
        }
    }
}
