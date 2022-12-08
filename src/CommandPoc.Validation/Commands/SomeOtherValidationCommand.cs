using CommandPoc.Core.Messages;

namespace CommandPoc.Validation.Commands
{
    public class SomeOtherValidationCommand : Command<bool>
    {
        public Guid ValidationId { get; private set; }
        public string Directory { get; private set; }
    
        public SomeOtherValidationCommand(
            Guid validationId, 
            string directory
        )
        {
            ValidationId = validationId;
            Directory = directory;
        }
    }
}