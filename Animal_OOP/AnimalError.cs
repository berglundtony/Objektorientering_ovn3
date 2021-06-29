using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_OOP
{
    public class AnimalError : UserError
    {
        public override string UEMessage()
        {
            return "You havent got the right input type for this animal, This fired an error!";
        }
    }
}
