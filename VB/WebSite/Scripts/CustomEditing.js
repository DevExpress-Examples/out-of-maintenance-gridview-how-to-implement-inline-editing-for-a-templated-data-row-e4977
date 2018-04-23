var index;
var isEdit = false;
function OnEditButtonClick(i) {
    if (isEdit == false) {
        index = i;
        SetEditorsEnabled(true);
        ShowEditUpdateCancelButtons(true);
        isEdit = true;
    }
    else
        return;
}
function UpdateGrid() {
    dataobject = {
        ID: gridView.GetRowKey(index),
        CanSpeakReceived: GetValue("CheckCanSpeakReceived"),
        CanUnderstandReceived: GetValue("CheckCanUnderstandReceived"),
        CanSpeakExpressed: GetValue("CheckCanSpeakExpressed"),
        CanWriteExpressed: GetValue("CheckCanWriteExpressed"),
        CanUnderstandExpressed: GetValue("CheckCanUnderstandExpressed"),
        CanWriteReceived: GetValue("CheckCanWriteReceived")
    };
    $.ajax({
        type: 'POST',
        url: '@Url.Action("UpdateGridView")',
        dataType: "json",
        data: dataobject,
        complete: function () { ShowEditUpdateCancelButtons(false); SetEditorsEnabled(false); isEdit = false; },
    });
}

function SetEditorsEnabled(enabled) {
    SetEnabled("CheckCanSpeakReceived", enabled);
    SetEnabled("CheckCanWriteReceived", enabled);
    SetEnabled("CheckCanUnderstandReceived", enabled);
    SetEnabled("CheckCanSpeakExpressed", enabled);
    SetEnabled("CheckCanWriteExpressed", enabled);
    SetEnabled("CheckCanUnderstandExpressed", enabled);
}
function ShowEditUpdateCancelButtons(iseditmode) {
    ASPxClientControl.GetControlCollection().GetByName("Update" + index).SetVisible(iseditmode);
    ASPxClientControl.GetControlCollection().GetByName("Cancel" + index).SetVisible(iseditmode);
    ASPxClientControl.GetControlCollection().GetByName("Edit" + index).SetVisible(!iseditmode);
}
function OnCancelClick(s, e) {
    gridView.Refresh();
    isEdit = false;
}
function SetEnabled(name, isenabled) {
    ASPxClientControl.GetControlCollection().GetByName(name + index).SetEnabled(isenabled);
}
function GetValue(name) {
    return ASPxClientControl.GetControlCollection().GetByName(name + index).GetValue();
}