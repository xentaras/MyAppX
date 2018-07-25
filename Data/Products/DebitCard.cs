using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class DebitCard : IProduct 
    {
        public DebitCard()
        {
            
        }

        public bool IsApplicable { private set; get; }

        public string Name => Strings.DebitCard;

        public bool IsSelected { get; set; }

        public void CheckIfApplicable(Answers answers, IProduct[] accounts)
        {
            IsApplicable =
                accounts.Where(i => i.GetType() != typeof(JuniorSaverAccount)).Any(i => i.IsSelected);
        }
    }
}
