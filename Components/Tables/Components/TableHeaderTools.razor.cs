using Microsoft.AspNetCore.Components;
using TablerForNet.Tabler.Components.Tables;

namespace TablerForNet.Tabler.Components.Tables
{
    public class TableHeaderToolsBase<TableItem> : ComponentBase
    {
        [CascadingParameter(Name = "Table")] public ITable<TableItem> Table { get; set; }

    }
}