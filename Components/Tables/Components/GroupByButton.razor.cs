namespace TablerForNet.Components
{
    public partial class GroupByButtonBase<Item> : ComponentBase
    {
        [CascadingParameter(Name = "Table")] public ITable<Item> Table { get; set; }

        protected async Task SetGroup(ITableColumn<Item> column)
        {
            await column.GroupByMeAsync();
        }
    }
}

