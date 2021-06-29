using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_OOP
{
    public class PersonError : UserError
    {
        public override string UEMessage()
        {
            return "You must write the right input for this wolfman.";
        }
    }
}
