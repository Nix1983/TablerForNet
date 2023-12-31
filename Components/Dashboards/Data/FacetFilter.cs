﻿namespace TablerForNet.Components
{
    public class FacetFilter<TItem> where TItem : class
    {
        public DataFilter<TItem> Filter { get; set; }
        public List<TItem> Items { get; set; }
        public IEnumerable<TItem> FilteredItems { get; set; }
        public bool Active { get; set; }
        public int CountAll { get; set; }
        public Func<FacetFilter<TItem>, string> FilterLabel { get; set; }

        public string GetLabel()
        {
            if (FilterLabel != null)
            {
                return FilterLabel(this);
            }
            else
            {
                return $"{Filter.Name} ({CountAll})";
            }

        }
    }
}
