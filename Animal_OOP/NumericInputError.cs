using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_OOP
{
    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field.This fired an error!";
        }
    }
}
