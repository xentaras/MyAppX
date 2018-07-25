﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class CurrentAccountPlus : IProduct
    {
        public CurrentAccountPlus()
        {

        }

        public bool IsApplicable { private set; get; }

        public string Name => Strings.CurrentAccountPlus;

        public bool IsSelected { get; set; }

        public void CheckIfApplicable(Answers answers, IProduct[] accounts)
        {
            IsApplicable =
                answers.Age != AgeEnum.Young &&
                answers.Income == IncomeEnum.Rich;
        }
    }
}