using System;
using System.Collections.Generic;
using FacadeLayer;
using EntityLayer;
using System.ComponentModel.DataAnnotations;


namespace BusinessLogicLayer
{
    public class BLLDB
    {
        public static int insert(myClass obj)
        {
            ValidationContext context = new ValidationContext(obj, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(obj, context, errors, true))
            {
                string strErrors = "";
                foreach (ValidationResult result in errors)
                {
                    strErrors += result.ErrorMessage + Environment.NewLine;
                }
                throw new Exception(strErrors);
            }
            else
            {
                return myAbsDB.insert(obj);
            }
        }
        public static bool update(myClass obj)
        {
            return myAbsDB.update(obj);
        }

    }
}
