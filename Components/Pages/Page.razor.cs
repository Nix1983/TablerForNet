﻿namespace TablerForNet.Components.Pages
{
    public partial class Page : TablerBaseComponent
    {
        protected override string ClassNames => ClassBuilder
            .Add("page")
            .Add(BackgroundColor.GetColorClass("bg"))
            .Add(TextColor.GetColorClass("text"))
            .ToString();
    }
}