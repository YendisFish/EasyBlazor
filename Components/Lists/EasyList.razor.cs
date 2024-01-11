using Microsoft.AspNetCore.Components;

namespace EasyBlazor.Components.Lists;

public partial class EasyList : StateComponent
{
    [Parameter] public ListType type { get; set; }
    [Parameter] public List<string> items { get; set; } = new();

    public void Add(string element)
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