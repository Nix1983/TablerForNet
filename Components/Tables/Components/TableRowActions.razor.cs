namespace TablerForNet.Components
{
    public class TableRowActionsBase<TableItem> : TableRowComponentBase<TableItem>
    {
        [Parameter] public ITableRowActions<TableItem> Table { get; set; }
        [Parameter] public TableItem Item { get; set; }

       
        protected bool CanDeleteItem(TableItem item)
        {
            if (!Table.AllowDelete)
            {
                return false;
            }

            if (Table.AllowDeleteExpression != null)
            {
                return Table.AllowDeleteExpression.Invoke(item);
            }

            return true;
        }
    }
}