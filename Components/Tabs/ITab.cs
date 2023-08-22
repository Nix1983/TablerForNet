using Microsoft.AspNetCore.Components;

namespace TablerForNet.Tabler.Components
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
