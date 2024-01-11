using Microsoft.AspNetCore.Components;

namespace EasyBlazor.Components.Tables;

public partial class EasyRow : StateComponent
{
    [Parameter] public string ColumnClass { get; set; } = "";
    [Parameter] public string ColumnId { get; set; } = "";
    [Parameter] public List<string> Columns { get; set; } = new();
}