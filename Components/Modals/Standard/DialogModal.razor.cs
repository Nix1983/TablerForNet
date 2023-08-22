using Microsoft.AspNetCore.Components;
using TablerForNet.Tabler.Services;

namespace TablerForNet.Tabler.Components.Modals
{
    public partial class DialogModal : ComponentBase
    {
        [Inject] private IModalService modalService { get; set; }

        [Parameter] public DialogOptions Options { get; set; }
        private void Cancel()
        {
            modalService.Close();
        }

        private void Ok()
        {
            modalService.Close(ModalResult.Ok());
        }



    }
}
