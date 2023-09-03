namespace TablerForNet.Components
{
    public abstract class NavbarBase :ComponentBase
    {
        [Parameter] public RenderFragment? ChildContent { get; set; }
        [Parameter] public EventCallback<MouseEventArgs> OnClick { get; set; }
    }
}
