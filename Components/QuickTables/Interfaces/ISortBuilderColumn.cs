namespace TablerForNet.Components
{
    public interface ISortBuilderColumn<TGridItem>
    {
        public GridSort<TGridItem> SortBuilder { get; }
    }
}