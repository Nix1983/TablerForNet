﻿using TablerForNet.Tabler.Components;

namespace TablerForNet.Tabler
{
    public partial class Tabs : TablerBaseComponent
    {
        public ITab ActiveTab { get; private set; }

        public void AddTab(ITab tab)
        {
            if (ActiveTab == null)
            {
                SetActivateTab(tab);
            }
        }

        public void RemoveTab(ITab tab)
        {
            if (ActiveTab == tab)
            {
                SetActivateTab(null);
            }
        }

        public void SetActivateTab(ITab tab)
        {
            if (tab == null)
            {
                ActiveTab = null;
                StateHasChanged();
                return;
            }

            if (ActiveTab != tab)
            {
                ActiveTab = tab;
                StateHasChanged();
            }
        }
    }
}
