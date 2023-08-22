namespace TablerForNet.Services
{
    public class TablerService
    {
        private readonly IJSRuntime jsRuntime;

        public TablerService(IJSRuntime jSRuntime)
        {
            this.jsRuntime = jSRuntime;
        }

        public async Task SaveAsFile(string fileName, string href)
        {
            await jsRuntime.InvokeVoidAsync("tabler.saveAsFile", fileName, href);
        }

        public async Task PreventDefaultKey(ElementReference element, string eventName, string[] keys)
        {
            await jsRuntime.InvokeVoidAsync("tabler.preventDefaultKey", element, eventName, keys);
        }

        public async Task FocusFirstInTableRow(ElementReference tableRow)
        {
            await jsRuntime.InvokeVoidAsync("tabler.focusFirstInTableRow", tableRow, "");
        }

        public async Task NavigateTable(ElementReference tableCell, string key)
        {
            await jsRuntime.InvokeVoidAsync("tabler.navigateTable", tableCell, key);
        }

        public async Task ScrollToFragment(string fragmentId)
        {
            await jsRuntime.InvokeVoidAsync("tabler.scrollToFragment", fragmentId);
        }

        public async Task ShowAlert(string message)
        {
            await jsRuntime.InvokeVoidAsync("tabler.showAlert", message);
        }

        public async Task CopyToClipboard(string text)
        {
            await jsRuntime.InvokeVoidAsync("tabler.copyToClipboard", text);
        }

        public async Task<string> ReadFromClipboard()
        {
            return await jsRuntime.InvokeAsync<string>("tabler.readFromClipboard");
        }

        public async Task DisableDraggable(ElementReference container, ElementReference element)
        {
            await jsRuntime.InvokeVoidAsync("tabler.disableDraggable", container, element);
        }

        public async Task SetElementProperty(ElementReference element, string property, object value)
        {
            await jsRuntime.InvokeVoidAsync("tabler.setPropByElement", element, property, value);
        }

        public async Task OpenModal()
        {
            await jsRuntime.InvokeVoidAsync("tabler.addClassToBody", "modal-open");
        }

        public async Task CloseModal()
        {
            await jsRuntime.InvokeVoidAsync("tabler.removeClassFromBody", "modal-open");
        }

    }


}
