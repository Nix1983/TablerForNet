﻿namespace TablerForNet.Components.Accordions
{
    public partial class Accordion : TablerBaseComponent
    {
        private List<AccordionItem> Items { get; set; } = new();
        [Parameter] public bool MultipleOpen { get; set; }

        public void AddAccordionItem(AccordionItem item)
        {
            Items.Add(item);
            StateHasChanged();
        }

        private void SetExpanded(AccordionItem item)
        {
            var oldExpanded = item.IsExpanded;

            foreach (var accordionItem in Items)
            {
                if (item == accordionItem)
                {
                    accordionItem.IsExpanded = !oldExpanded;
                }
                else if (!MultipleOpen)
                {
                    accordionItem.IsExpanded = false;
                }
            }

            StateHasChanged();
        }
    }
}