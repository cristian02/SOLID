﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    internal class Dog : Animal
    {
        public override void Join()
        {
        }

        public override void Run()
        {
        }

        public override void Walk()
        {
        }

        public override void Swim()
        {
            throw new Exception(); 
        }
        public override void Fly()
        {
            throw new Exception(); 
        }
    }
}
