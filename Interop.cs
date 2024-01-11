using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace EasyBlazor;

public static class Interop
{
    public static void SetById(string id, string html, IJSRuntime runtime) => runtime.InvokeVoidAsync("setById", CancellationToken.None, new object[] { id, html });
    public static void SetById(string id, MarkupString html, IJSRuntime runtime) => runtime.InvokeVoidAsync("setById", CancellationToken.None, new object[] { id, html.Value });
}