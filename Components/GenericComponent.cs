using Microsoft.AspNetCore.Components;

namespace EasyBlazor.Components;

public abstract class GenericComponent<T> : StateComponent
{
    [Parameter] public T child { get; set; }
    [Parameter] public RenderFragment<T> extractor { get; set; }
}