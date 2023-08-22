﻿using Microsoft.AspNetCore.Components;

namespace TablerForNet.Tabler.Components.Tables.Components
{
    public class DetailsRowBase<TableItem> : ComponentBase // ComponentBase
    {
        [Parameter] public IDetailsTable<TableItem> Table { get; set; }
        [Parameter] public TableItem Item { get; set; }
    }
}