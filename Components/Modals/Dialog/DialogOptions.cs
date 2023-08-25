namespace TablerForNet.Components.Modals.Dialog
{
    public class DialogOptions
    {
        public string MainText { get; set; }
        public string SubText { get; set; }
        public IIconType IconType { get; set; }
        public string CancelText { get; set; } = "Cancel";
        public string OkText { get; set; } = "Ok";
        public TablerColor StatusColor = TablerColor.Default;

    }
}
