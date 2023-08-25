﻿namespace TablerForNet.Services
{
    public interface IModalService
    {
        event Action OnChanged;
        IEnumerable<ModalModel> Modals { get; }
        Task<ModalResult> ShowAsync<TComponent>(string title, RenderComponent<TComponent> component, ModalOptions modalOptions = null) where TComponent : IComponent;
        void Close(ModalResult modalResult);
        void Close();
        Task<bool> ShowDialogAsync(DialogOptions options);

        void UpdateTitle(string title);
        void Refresh();

        ModalViewSettings RegisterModalView(ModalView modalView);
        void UnRegisterModalView(ModalView modalView);
    }
}
