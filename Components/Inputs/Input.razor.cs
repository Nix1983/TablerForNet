using Microsoft.AspNetCore.Components;

namespace TablerForNet.Tabler
{
    public partial class Input : TablerBaseComponent
    {
        protected override string ClassNames => ClassBuilder
            //.Add("card-tabs")
            .Add(BackgroundColor.GetColorClass("bg"))
            .Add(TextColor.GetColorClass("text"))
            .ToString();
    }
}