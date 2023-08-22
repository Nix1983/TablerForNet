using TablerForNet.Tabler.Services;

namespace TablerForNet.Tabler.Components.ObjectBrowser
{
    public partial class PropertyValueLink
    {
        [Inject] public IModalService ModalService { get; set; }
        [Parameter] public object PropertyValue { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        private async Task ObjectDetails()
        {
            if(PropertyValue != null)
            {
                var component = new RenderComponent<TablerForNet.Tabler.ObjectBrowser>().Set(e => e.Object, PropertyValue);
                var result = await ModalService.ShowAsync(PropertyValue.GetType().FullName, component, new ModalOptions { Size = ModalSize.XLarge });
            }
        
        }

    }
}