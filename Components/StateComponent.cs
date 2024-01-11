using Microsoft.AspNetCore.Components;

namespace EasyBlazor.Components;

public class StateComponent : ComponentBase
{
    [Parameter] public string Class { get; set; } = "";
    [Parameter] public string Id { get; set; } = "";

    public void Update() => StateHasChanged();
}