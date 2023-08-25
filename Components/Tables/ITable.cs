﻿namespace TablerForNet.Components
{
    public interface ITable<TableItem>
    {
        int PageSize { get; }
        bool ShowFooter { get; set; }
        bool ResetSortCycle { get; set; }
        bool ShowSearch { get; set; }
        bool MultiSelect { get; set; }
        int PageNumber { get; }
        int TotalCount { get; }
        int VisibleColumnCount { get; }
        List<TableItem> SelectedItems { get; set; }
        IList<TableItem> Items { get; }
        IDataProvider<TableItem> DataProvider { get; set; }
        RenderFragment<TableItem> RowActionTemplate { get; set; }
        bool ShowCheckboxes { get; set; }
        bool HasRowActions { get; }
        Task FirstPage();
        Task SetPage(int pageNumber);
        Task NextPage();
        Task PreviousPage();
        Task LastPage();
        Task ClearSelectedItem();
        List<IColumn<TableItem>> Columns { get; }
        List<IColumn<TableItem>> VisibleColumns { get; }
        void AddColumn(IColumn<TableItem> column);
        void RemoveColumn(IColumn<TableItem> column);
        Task RefreshItems(MouseEventArgs args);
        Task Search(string searchText);
        Task SelectAll();
        Task UnSelectAll();
        Task Update(bool resetPage = false);
        void SetPageSize(int pageSize);
        string SearchText { get; set; }
        string GetColumnWidth();
        Func<Task<IList<TableItem>>> OnRefresh { get; set; }
        bool HasActionColumn { get; }
    }

    public interface ITableState<TableItem>
    {
        string SearchText { get; set; }
        int PageSize { get; set; }
        bool ShowFooter { get; set; }
        bool ShowSearch { get; set; }
        bool UseNaturalSort { get; set; }
        int PageNumber { get; set; }
        int TotalCount { get; set; }
        int VisibleColumnCount { get; }
        Task Update(bool resetPage = false);
        TableItem CurrentEditItem { get; }

    }

    public interface IPopupEditTable<TItem>
    {
        List<IColumn<TItem>> Columns { get; }
        List<IColumn<TItem>> VisibleColumns { get; }

        bool ShowCheckboxes { get; }
        TItem CurrentEditItem { get; }
        Task OnValidSubmit(EditContext editContext);
        bool IsAddInProgress { get; }
        Task CloseEdit();
        Task CancelEdit();
        bool IsRowValid { get;}
        Action<TableEditPopupOptions<TItem>> EditPopupMutator { get; set; }

    }

    public interface IInlineEditTable<TableItem>
    {
        List<IColumn<TableItem>> Columns { get; }
        List<IColumn<TableItem>> VisibleColumns { get; }
        bool ShowCheckboxes { get; }
        IList<TableItem> Items { get; }
        TableItem CurrentEditItem { get; }
        Task CloseEdit();
        Task CancelEdit();
        bool IsRowValid { get;}
        bool HasActionColumn { get; }
    }

    public interface ITableRow<TableItem>
    {
        List<IColumn<TableItem>> Columns { get; }
        List<IColumn<TableItem>> VisibleColumns { get; }
        IList<TableItem> Items { get; }
        TableItem SelectedItem { get; }
        List<TableItem> SelectedItems { get; }
        bool ShowCheckboxes { get; }
        RenderFragment<TableItem> DetailsTemplate { get; }
        RenderFragment<TableItem> RowActionTemplate { get; set; }
        RenderFragment<TableItem> RowActionEndTemplate { get; set; }
        bool AllowEdit { get; }
        bool AllowDelete { get; }
        bool HasRowActions { get; }
        EventCallback<TableItem> OnItemSelected { get; }
        EventCallback<List<TableItem>> SelectedItemsChanged { get; }
        Task OnDeleteItem(TableItem item);
        void EditItem(TableItem item);
        Task SetSelectedItem(TableItem item);
        Task RowClicked(TableItem item);
        bool KeyboardNavigation { get; }
        bool HasActionColumn { get; }
        Func<TableItem, bool> AllowDeleteExpression { get; set; }
        Func<TableItem, bool> AllowEditExpression { get; set; }
    }

    public interface ITableRowActions<TableItem>
    {
        Func<TableItem, bool> AllowDeleteExpression { get; }
        bool AllowDelete { get; }
        string GetColumnWidth();
    }

    public interface IDetailsTable<TableItem>
    {
        int VisibleColumnCount { get; }
        Task ClearSelectedItem();
        RenderFragment<TableItem> DetailsTemplate { get; }
    }
}