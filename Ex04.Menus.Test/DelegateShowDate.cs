﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class DelegateShowDate
    {
        public void Excute()
        {
            string date = DateTime.Now.ToShortDateString();
            Console.WriteLine(date);
        }
    }
}
