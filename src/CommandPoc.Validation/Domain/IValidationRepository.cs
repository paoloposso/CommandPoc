using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandPoc.Validation.Domain.Model;

namespace CommandPoc.Validation.Domain
{
    public interface IValidationRepository
    {
        Task UpdateValidationStatus(Guid validationId, string newStatus);
        Task<TerraformValidation> GetTerraformValidation(Guid validationId);
    }
}