using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace TablerForNet.Tabler
{
    public enum BadgeShape
    {
        Default,
        Pill
    }

    public enum BadgeSize
    {
        Default,
        Large
    }

    public partial class Badge : TablerBaseComponent
    {
        [Parameter] public BadgeShape Shape { get; set; }
        [Parameter] public BadgeSize Size { get; set; } = BadgeSize.Default;
        protected string HtmlTag => "span";

        protected override string ClassNames => ClassBuilder
            .Add("badge")
            .Add(TextColor.GetColorClass("text"))
            .Add("badge-default")
            .AddCompare("badge-md", Size, BadgeSize.Default)
            .Add(BackgroundColor.GetColorClass("bg", ColorType.Default))
            .AddCompare("badge-pill", Shape, BadgeShape.Pill)
            .AddIf("cursor-pointer", OnClick.HasDelegate)
            .ToString();
    }


}
