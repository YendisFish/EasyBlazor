using Microsoft.AspNetCore.Components;

namespace EasyBlazor.Components.Tables;

public partial class EasyHeader : StateComponent
{
    [Parameter] public List<string> Columns { get; set; } = new();
    [Parameter] public string ColumnClass { get; set; } = "";
    [Parameter] public string ColumnId { get; set; } = "";
}