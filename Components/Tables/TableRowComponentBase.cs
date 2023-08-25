namespace TablerForNet.Components
{
    public abstract class TableRowComponentBase<TableItem> : ComponentBase
    {
        public string GetColumnWidth(ITableColumn<TableItem> column)
        {
            return !string.IsNullOrEmpty(column.Width) ? $"width:{column.Width}; " : null;
        }

        public virtual string GetColumnClass(ITableColumn<TableItem> column)
        {
            return new ClassBuilder()
                .Add(column.CssClass)
                .ToString();
        }
    }
}