using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_OOP
{
    public class DogError : UserError
    {
        public override string UEMessage()
        {
            return "This dog input fires an error!";
        }
    }
}
