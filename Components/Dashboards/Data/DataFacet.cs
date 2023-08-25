namespace TablerForNet.Components
{
    public class DataFacet<TItem> where TItem : class
    {
        public string Name { get; set; }
        public List<FacetFilter<TItem>> Filters { get; set; } = new();
        public bool IsActive => Filters.Any(e => e.Active);
    }
}
