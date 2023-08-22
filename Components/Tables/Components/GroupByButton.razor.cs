namespace TablerForNet.Components.Tables.Components
{
    public partial class GroupByButtonBase<Item> : ComponentBase
    {
        [CascadingParameter(Name = "Table")] public ITable<Item> Table { get; set; }

        protected async Task SetGroup(IColumn<Item> column)
        {
            await column.GroupByMeAsync();
        }
    }
}

