using Microsoft.AspNetCore.Components;

namespace EasyBlazor.Components.Tables;

public partial class EasyTable : StateComponent
{
    [Parameter] public EasyHeader Header { get; set; }
    [Parameter] public string RowClass { get; set; } = "";
    [Parameter] public string RowId { get; set; } = "";
    [Parameter] public List<EasyRow> Rows { get; set; } = new();
}