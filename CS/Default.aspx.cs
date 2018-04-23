using System;
using DevExpress.Web.Data;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {

    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);
        if(!IsPostBack)
            Grid.StartEdit(0);
    }

    protected void Grid_RowUpdating(object sender, ASPxDataUpdatingEventArgs e) {
        e.Cancel = true;
    }
    
    protected void Grid_CellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e) {
        SetupCalendarOwner(e.Editor as ASPxDateEdit);
    }

    protected void Grid_AutoFilterCellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e) {
        SetupCalendarOwner(e.Editor as ASPxDateEdit);
    }

    void SetupCalendarOwner(ASPxDateEdit editor) {
        if(editor == null) return;
        editor.PopupCalendarOwnerID = "__ReferenceDateEdit";
    }

}
