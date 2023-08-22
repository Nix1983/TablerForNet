namespace TablerForNet.Components.QuickTables.Columns
{
    public interface ISortBuilderColumn<TGridItem>
    {
        public GridSort<TGridItem> SortBuilder { get; }
    }
}