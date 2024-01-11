using Microsoft.AspNetCore.Components;

namespace EasyBlazor.Components;

public partial class MarkupComponent : StateComponent
{
    [Parameter] public MarkupString innerHtml { get; set; } = new("");
}