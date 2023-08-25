﻿namespace TablerForNet.Components
{
    public class GroupHeaderTableRowBase<TableItem> : ComponentBase
    {
        [Parameter] public TableResult<object, TableItem> Group { get; set; }
        [Parameter] public EventCallback<TableResult<object, TableItem>> GroupChanged { get; set; }

        protected async Task ToogleExpanded()
        {
            Group.Expanded = !Group.Expanded;
            await GroupChanged.InvokeAsync(Group);
        }

        protected string ExpandedCss()
        {
            if (Group.Expanded)
            {
                return "arrow-down";
            }
            return "arrow-right";
        }
    }
}