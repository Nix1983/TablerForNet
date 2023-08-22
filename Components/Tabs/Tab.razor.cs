﻿using TablerForNet.Tabler.Components;

namespace TablerForNet.Tabler
{
   public partial class Tab : TablerBaseComponent, ITab
    {
        [CascadingParameter] Tabs ContainerTabSet { get; set; }
        [Parameter] public string Title { get; set; }
        [Parameter] public RenderFragment Header { get; set; }

        string TitleCssClass => ContainerTabSet.ActiveTab == this ? "active" : null;

        protected override void OnInitialized()
        {
            ContainerTabSet.AddTab(this);
        }

        public void Dispose()
        {
            ContainerTabSet.RemoveTab(this);
        }

        void Activate()
        {
            ContainerTabSet.SetActivateTab(this);
            OnClick.InvokeAsync();
        }
    }
}
