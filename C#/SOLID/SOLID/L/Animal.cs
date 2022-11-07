using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    abstract class Animal
    {
        public virtual void Walk() { }

        public virtual void Swim() { }

        public virtual void Fly() { }

        public virtual void Run() { }

        public virtual void Join() { }
    }
}
