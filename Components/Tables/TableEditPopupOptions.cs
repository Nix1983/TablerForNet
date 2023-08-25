namespace TablerForNet.Components
{
    public class TableEditPopupOptions<TItem>
    {
        public string Title { get; set; } 
        public ModalOptions ModalOptions { get; set; }

        public TItem CurrentEditItem { get; internal set; }
        public bool IsAddInProgress { get; internal set; }
    }
}
