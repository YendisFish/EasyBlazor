using Microsoft.AspNetCore.Components;

namespace EasyBlazor.Components;

public abstract class GenericComponent<T> : StateComponent
{
    [Parameter] public T child { get; set; } = default(T);
    [Parameter] public Func<T, string> extractor { get; set; }

    public void Update() => StateHasChanged();
}