using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class JuniorSaverAccount : IProduct
    {
        public JuniorSaverAccount()
        {

        }

        public bool IsApplicable { private set; get; }

        public string Name => Strings.JuniorSaverAccount;

        public bool IsSelected { get; set; }

        public void CheckIfApplicable(Answers answers, IProduct[] accounts)
        {
            IsApplicable =
                answers.Age == AgeEnum.Young;
        }
    }
}
