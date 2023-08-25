
namespace TablerForNet.Components.Modals.Dialog
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
