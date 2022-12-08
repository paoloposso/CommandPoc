namespace CommandPoc.Validation.Domain.Model
{
    public class TerraformValidation
    {
        public TerraformValidation(Guid validationId) 
        {
            ValidationId = validationId;
   
        }
        public Guid ValidationId { get; set; }
    }
}