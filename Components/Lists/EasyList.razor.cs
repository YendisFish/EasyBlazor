using Microsoft.AspNetCore.Components;

namespace EasyBlazor.Components.Lists;

public partial class EasyList<T> : StateComponent
{
    [Parameter] public ListType type { get; set; } = ListType.Ordered;
    [Parameter] public List<T> items { get; set; } = new();
    [Parameter] public string ElementClass { get; set; } = "";
    [Parameter] public string ElementId { get; set; } = "";
    [Parameter] public RenderFragment<T> child { get; set; }

    public void Add(T element)
    {
        items.Add(element);
        this.Update();
    }
}

public enum ListType
{
    Ordered,
    Unordered
}