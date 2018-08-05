using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class JuniorSaverAccount : Product
    {
        public JuniorSaverAccount()
        {

        }

        protected override string GetName() => Strings.JuniorSaverAccount;

        public override void CheckIfApplicable(Answers answers, IEnumerable<Product> accounts)
        {
            IsApplicable =
                answers.Age == AgeEnum.Young;

            if (IsApplicable != true)
            {
                if (answers.Age != AgeEnum.Young)
                    WhyNot = Strings.TooOld;
            }
            else
            {
                WhyNot = Name;
            }
        }
    }
}
