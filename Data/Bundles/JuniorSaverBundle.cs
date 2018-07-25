using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    class JuniorSaverBundle : IBundleTemplate
    {
        public JuniorSaverBundle(Answers answers)
        {
            IsApplicable =
                answers.Age == AgeEnum.Young;
        }

        public int Value => 0;

        public bool IsApplicable { private set; get; }

        public string Name => Strings.JuniorSaver;

        public Type[] TemplateCreditCards =>
            new Type[] { };

        public Type TemplateAccount =>
            typeof(JuniorSaverAccount);
    }
}
