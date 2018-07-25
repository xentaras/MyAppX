using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public interface IBundleTemplate
    {
        Type[] TemplateCreditCards { get; }

        Type TemplateAccount { get; }

        int Value { get; }

        bool IsApplicable { get; }

        string Name { get; }
    }
}
