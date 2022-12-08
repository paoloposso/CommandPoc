using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandPoc.Validation.Domain.Model;

namespace CommandPoc.Validation.Domain.Services
{
    public class TerraformValidationService
    {
        public string Validate(TerraformValidation validation) 
        {
            return "OK";
        }
    }
}