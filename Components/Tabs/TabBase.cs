namespace TablerForNet.Components
{
    public abstract class TabBase : ComponentBase
    {
        [Parameter] public RenderFragment? ChildContent { get; set; }
    }

    public enum TabAlignment
    {
        Left,
        Right,
        Center
    }
}
