#pragma checksum "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\Pages\CodeViewer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af094852fa3fd803848284219badec1291701747"
// <auto-generated/>
#pragma warning disable 1591
namespace TCreator.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\_Imports.razor"
using TCreator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\_Imports.razor"
using TCreator.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\_Imports.razor"
using BlazorMonaco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class CodeViewer : CodeViewerBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorMonaco.MonacoEditor>(0);
            __builder.AddAttribute(1, "Id", "any-id-string");
            __builder.AddAttribute(2, "ConstructionOptions", new System.Func<BlazorMonaco.MonacoEditor, BlazorMonaco.StandaloneEditorConstructionOptions>(
#nullable restore
#line 4 "C:\Users\Marvin\Documents\GitHub\TCreator\TCreator\Pages\CodeViewer.razor"
                                                      EditorConstructionOptions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "CssClass", "editor");
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.AddMarkupContent(5, "<style>\r\n    .editor {\r\n        width: 100%;\r\n        height: 100%;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
