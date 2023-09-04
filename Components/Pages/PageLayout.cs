
namespace TablerForNet.Components
{
    public enum PageLayout
    {
        Boxed,
        Fluid,
        None
    }

    public static class PageLayoutExtensions
    {
        public static string ToCssClass(this PageLayout layout)
        {
            switch (layout)
            {
                case PageLayout.Boxed:
                    return "layout-boxed";
                case PageLayout.Fluid:
                    return "layout-fluid";
                case PageLayout.None:
                    return "";  // oder eine entsprechende CSS-Klasse für "None"
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
