using Microsoft.AspNetCore.Components;
using System;
using TablerForNet.Tabler.Components.Tables;

namespace TablerForNet.Tabler.Components.Tables
{
    public class PagerBase<Item> : ComponentBase
    {
        [CascadingParameter(Name = "Table")]
        public ITable<Item> Table { get; set; }

        public bool ShowPageNumber { get; set; }
        protected int TotalPages { get; set; }
        public int SkipQuantity { get; private set; }

        protected override void OnParametersSet()
        {
            if(Table.TotalCount == 0)
            {
                ShowPageNumber = false;
                return;
            }
            var pageCount = (decimal)Table.TotalCount / (decimal)Table.PageSize;
            TotalPages = (int)Math.Ceiling(pageCount);
            SkipQuantity = (Table.PageNumber) * Table.PageSize;
            ShowPageNumber = Table.TotalCount > Table.PageSize;
        }

        public string FirstItemNumber => (SkipQuantity + 1).ToString();
        public string LastItemNumber => Math.Min((SkipQuantity + Table.PageSize), Table.TotalCount).ToString();
    }
}
