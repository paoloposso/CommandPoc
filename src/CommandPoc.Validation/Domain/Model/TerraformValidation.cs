namespace CommandPoc.Validation.Domain.Model
{
    public struct TerraformValidation
    {
        public TerraformValidation(Guid validationId, string status, DateTime created) 
        {
            ValidationId = validationId;
            Status = status;
            Created = created;
        }

        public void SetStatus(string status)
        {
            Status = status;
        }

        public Guid ValidationId { get; private set; }
        public string Status { get; private set; }
        public DateTime Created { get; }
    }
}