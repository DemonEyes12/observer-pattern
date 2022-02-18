﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ConcreteObserver : IObserver
    {
        int count = 0;
        public void update()
        {
            count++;
        }
        public int GetCounter()
        {
            return count;
        }
    }
}