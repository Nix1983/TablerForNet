namespace TablerForNet.Components
{
    public delegate ValueTask<GridItemsProviderResult<TGridItem>> GridItemsProvider<TGridItem>(
        GridItemsProviderRequest<TGridItem> request);
}

