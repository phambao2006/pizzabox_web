#pragma checksum "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34a728ffe6018ecf114113272b0de27539fee352"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Order), @"mvc.1.0.view", @"/Views/Order/Order.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34a728ffe6018ecf114113272b0de27539fee352", @"/Views/Order/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Domain.Models.Order>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34a728ffe6018ecf114113272b0de27539fee3523017", async() => {
                WriteLiteral(@"


    <table class=""table table-dark"">
        <thead>
            <tr>
                <th scope=""col"">Pizza</th>
                <th scope=""col"">Size</th>
                <th scope=""col"">Crust</th>
                <th scope=""col"">Toppings</th>
                <th scope=""col"">Price</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 16 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml"
              int index = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml"
             foreach (var pizza in Model.Pizzas)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 20 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml"
                           Write(index);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 21 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml"
               Write(pizza.Size.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml"
               Write(pizza.Crust.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 24 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml"
                     foreach (var topping in pizza.Toppings)
                    {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml"
               Write(topping.Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml"
                             Write(Html.Raw(" "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml"
                                                
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    \r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml"
               Write(pizza.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 33 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml"
                  index++;

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tr>\r\n");
#nullable restore
#line 35 "/mnt/c/Users/Bao/revature/pizzabox_web/PizzaBox.Client/Views/Order/Order.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n    </table>\r\n    <a href=\"../home/index\">Order More</a>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Domain.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
