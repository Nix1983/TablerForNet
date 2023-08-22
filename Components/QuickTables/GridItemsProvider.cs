namespace TablerForNet.Components.QuickTables
{
    public delegate ValueTask<GridItemsProviderResult<TGridItem>> GridItemsProvider<TGridItem>(
        GridItemsProviderRequest<TGridItem> request);
}

