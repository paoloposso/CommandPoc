using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandPoc.Validation.Domain.Model;

namespace CommandPoc.Validation.Data.Repository
{
    public class ValidationRepository : IValidationRepository
    {
        public Task<TerraformValidation> GetTerraformValidation(Guid validationId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateValidationStatus(Guid validationId, string status)
        {
            return Task.CompletedTask;
        }
    }
}