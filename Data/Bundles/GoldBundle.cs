using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class GoldBundle : IBundleTemplate
    {
        public GoldBundle(Answers answers)
        {
            IsApplicable = 
                answers.Age != AgeEnum.Young && 
                answers.Income == IncomeEnum.Rich;
        }

        public int Value => 3;

        public bool IsApplicable { private set; get; }

        public string Name => Strings.Gold;

        public Type[] TemplateCreditCards => 
            new Type[] 
            {
                typeof(DebitCard),
                typeof(GoldCreditCard)
            } ;

        public Type TemplateAccount => 
            typeof(CurrentAccountPlus);
    }
}
