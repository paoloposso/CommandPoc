using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPoc.Validation.Domain.Model
{
    public class TerraformValidation
    {
        public TerraformValidation(string validationId) 
        {
            ValidationId = validationId;
   
        }
        public string ValidationId { get; set; }
    }
}