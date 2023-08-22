namespace TablerForNet.Components.Inputs
{
    public partial class Input : TablerBaseComponent
    {
        protected override string ClassNames => ClassBuilder
            .Add(BackgroundColor.GetColorClass("bg"))
            .Add(TextColor.GetColorClass("text"))
            .ToString();
    }
}