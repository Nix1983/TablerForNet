﻿namespace TablerForNet.Virtualize
{
    public partial class VirtualizeOptional<TItem>
    {
        [Parameter] public IEnumerable<TItem> Items { get; set; }
        [Parameter] public RenderFragment<TItem> ChildContent { get; set; }
        [Parameter] public bool Virtualize { get; set; }
    }
}
