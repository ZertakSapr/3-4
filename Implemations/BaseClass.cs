using System;
using System.Collections.Generic;
using System.Text;

namespace _3_4
{
    abstract class BaseClass: IBase
    {
        private bool flag { get; set; }

        protected BaseClass(bool Flag)
        {
            flag = Flag;
        }
        public abstract void Print();

        protected abstract void UserFill();
        protected abstract void RndFill();


        public void TypeOfInizialization()
        {
            if (flag)
            {
                UserFill();

            }
            else
            {
                RndFill();
            }
        }
    }
}
