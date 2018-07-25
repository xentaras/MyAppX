using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public interface IProduct
    {
        void CheckIfApplicable(Answers answers, IProduct[] accounts);

        bool IsApplicable { get; }
        string Name { get; }

        bool IsSelected { get; set; }
    }
}
