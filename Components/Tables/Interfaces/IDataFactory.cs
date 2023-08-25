namespace TablerForNet.Components
{
    public interface ITableDataProvider<Item>
    {
        public Task<IEnumerable<TableResult<object, Item>>> GetData(List<ITableColumn<Item>> columns, ITableState<Item> state, IEnumerable<Item> items, bool resetPage = false, bool addSorting = true, Item moveToItem = default);
    }
}
