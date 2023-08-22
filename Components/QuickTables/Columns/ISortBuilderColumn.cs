namespace TablerForNet.Tabler.Components.QuickTables;

public interface ISortBuilderColumn<TGridItem>
{
    public GridSort<TGridItem> SortBuilder { get; }
}