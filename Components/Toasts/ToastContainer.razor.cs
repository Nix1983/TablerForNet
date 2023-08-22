using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using TablerForNet.Tabler.Services;

namespace TablerForNet.Tabler
{
    public partial class ToastContainer : ComponentBase
    {
        [Inject] public ToastService ToastService { get; set; }

        protected override void OnInitialized()
        {
            ToastService.OnChanged += OnToastChanged;
        }

        public async Task OnToastChanged()
        {
            await InvokeAsync(() => { StateHasChanged(); });
        }

        public void Dispose()
        {
           ToastService.OnChanged -= OnToastChanged;
        }
    }
}