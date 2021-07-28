#pragma checksum "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9a0980758e85319ed55b44afe394aa741e3f380"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorEmployeeManagement.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\_Imports.razor"
using BlazorEmployeeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\_Imports.razor"
using BlazorEmployeeManagement.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EmployeeList</h3>\r\n");
#nullable restore
#line 5 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\Pages\EmployeeList.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "                <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 8 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\Pages\EmployeeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-deck");
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 12 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\Pages\EmployeeList.razor"
     foreach (var employee in Employees)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card m-3");
            __builder.AddAttribute(8, "style", "min-width: 18rem; max-width:30.5%;");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-header");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "h3");
            __builder.AddContent(14, 
#nullable restore
#line 16 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\Pages\EmployeeList.razor"
                     employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 16 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\Pages\EmployeeList.razor"
                                         employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 18 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\Pages\EmployeeList.razor"
                                                           employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddMarkupContent(23, @"<div class=""card-footer text-center"">
                <a href=""#"" class=""btn btn-primary m-1"">View</a>

                <a href=""#"" class=""btn btn-primary m-1"">Edit</a>

                <a href=""#"" class=""btn btn-danger m-1"">Delete</a>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 27 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\Pages\EmployeeList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 30 "C:\Users\admin\source\repos\BlazorEmployeeManagement\BlazorEmployeeManagement\Pages\EmployeeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
