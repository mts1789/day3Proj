using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC5Course.Models
{
    public class myValidationAttribute:DataTypeAttribute
    {
        public myValidationAttribute() :base("myValid")//驗證種類名稱
        {

        }

        public override bool IsValid(object value)
        {
            short i5;
            bool ii = Int16.TryParse(value.ToString(), out i5);
            if (i5 % 2 == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}