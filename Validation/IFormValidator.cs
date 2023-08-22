namespace TablerForNet.Validation
{
    public interface IFormValidator
    {
        Type Component { get; }
        Task<bool> ValidateAsync(object validatorInstance, EditContext editContext);
        bool Validate(object validatorInstance, EditContext editContext);
    }
}