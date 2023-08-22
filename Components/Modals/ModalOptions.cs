namespace TablerForNet.Components.Modals
{
    public class ModalOptions
    {
        /// <summary>
        /// Shows the header of the modal
        /// Has no effect on the header component
        /// </summary>
        public bool ShowHeader { get; set; } = true;
        public bool ShowCloseButton { get; set; } = true;
        public bool Scrollable { get; set; } = true;
        public bool CloseOnClickOutside { get; set; } = false;
        public bool BlurBackground { get; set; } = true;
        public bool Backdrop { get; set; } = true;
        public bool CloseOnEsc { get; set; } = false;
        public bool Draggable { get; set; } = false;
        public bool IsTitleLeftIcon { get; set; } = false;
        public bool IsTitleRightIcon { get; set; } = false;
        public int TitleRightIconSize { get; set; }
        public int TitleLeftIconSize { get; set; }
        public TablerColor TitleLeftIconColor { get; set; }
        public TablerColor TitleRightIconColor { get; set; }
        public IIconType TitleLeftIcon { get; set; }
        public IIconType TitleRightIcon { get; set; }
        public TablerColor TitleTextColor { get; set; } = TablerColor.White;
        public bool DarkMode { get; set; } = false;
        public TablerColor BorderColor = TablerColor.Dark;
        public ModalVerticalPosition VerticalPosition { get; set; }
        public ModalSize Size { get; set; } = ModalSize.Medium;
        public ModalFullscreen Fullscreen { get; set; } = ModalFullscreen.Never;
        public TablerColor? StatusColor { get; set; }
        public string MaxHeigth { get; set; }
        public string MaxWidth { get; set; }

        /// <summary>
        /// Set your own footer component
        /// </summary>
        public RenderFragment FooterComponent { get; set; }

        /// <summary>
        /// Set your own header component
        /// </summary>
        public RenderFragment HeaderComponent { get; set; }
    }

    public enum ModalVerticalPosition
    {
        Default = 0,
        Centered = 1
    }
}
