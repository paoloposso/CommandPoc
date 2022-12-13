using CommandPoc.Validation.Domain;
using CommandPoc.Validation.Domain.Model;

namespace CommandPoc.Validation.Data.Repository
{
    public class ValidationRepository : IValidationRepository
    {
        public Task<TerraformValidation> GetTerraformValidation(Guid validationId)
        {
            //this is mock
            return Task.FromResult(new TerraformValidation(validationId, "finished", DateTime.Now.AddDays(-7)));
        }

        public Task UpdateValidationStatus(Guid validationId, string newStatus)
        {
            return Task.CompletedTask;
        }
    }
}