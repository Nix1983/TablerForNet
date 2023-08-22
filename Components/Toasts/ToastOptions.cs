namespace TablerForNet.Components.Toasts
{
    public class ToastOptions
    {
        /// <summary>
        /// Delay in Seconds
        /// Set 0 to show it until manually removed
        /// </summary>
        public int Delay { get; set; } = 3;
        public bool ShowHeader { get; set; } = true;
        public bool ShowProgress { get; set; } = true;
        public bool AutoClose => Delay > 0;
        public bool DarkMode { get; set; } = false;
        public bool ShowHeaderClose { get; set; } = true;
    }
}
