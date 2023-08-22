namespace TablerForNet.Components.Statuses
{

    public partial class StatusDot : TablerBaseComponent
    {
        [Parameter] public bool Animate { get; set; }


        protected override string ClassNames => ClassBuilder
            .Add("status-dot")
            .AddIf(BackgroundColor.GetColorClass("status", ColorType.Default), BackgroundColor != TablerColor.Default)
            .AddIf("status-dot-animated", Animate)
            .AddIf("cursor-pointer", OnClick.HasDelegate)
            .ToString();
    }
}
