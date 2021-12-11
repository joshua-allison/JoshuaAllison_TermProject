#pragma checksum "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13214dabf9e4401b59efa7cff7a44c66c3fd88ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\_ViewImports.cshtml"
using JoshuaAllison_TermProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\_ViewImports.cshtml"
using JoshuaAllison_TermProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13214dabf9e4401b59efa7cff7a44c66c3fd88ec", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a91ad4f7034f7508d48d14c642764f270de70796", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Equipment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Equipment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary align-content-start mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success align-content-center ml-3 mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger align-content-end ml-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Dark Souls III - Item Database</h1>
    <p>An editable collection of items from the dark souls 3 video game, each with a breakdown of stats.</p>
    <p>This is a condensed (and incomplete) version of information found on the <a href=""https://darksouls3.wiki.fextralife.com/Dark+Souls+3+Wiki"" target=""_blank"">Dark Souls 3 Wiki.</a></p>
</div>

<h2>Equipment List</h2>

<h4 class=""text-right"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13214dabf9e4401b59efa7cff7a44c66c3fd88ec6781", async() => {
                WriteLiteral("Add New Equipment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n    <table class=\"table table-bordered table-striped justify-content-center align-content-center\">\r\n        <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
             foreach (var equipment in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"text-center font-weight-bold\">\r\n                    <h3> ");
#nullable restore
#line 21 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                    Write(equipment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /></h3>\r\n                    <p class=\"font-weight-normal\"></p>\r\n                    <img");
            BeginWriteAttribute("src", " src=", 1010, "", 1033, 1);
#nullable restore
#line 23 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1015, equipment.IconURL, 1015, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mb-3\">\r\n                    <p class=\"font-weight-normal font-italic\">\"");
#nullable restore
#line 24 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                                                          Write(equipment.FlavorText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"<br></p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13214dabf9e4401b59efa7cff7a44c66c3fd88ec9816", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                                                                                                                               WriteLiteral(equipment.EquipmentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                                                                                                                                                                       WriteLiteral(equipment.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13214dabf9e4401b59efa7cff7a44c66c3fd88ec13208", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                                                                                                                                WriteLiteral(equipment.EquipmentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                                                                                                                                                                        WriteLiteral(equipment.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13214dabf9e4401b59efa7cff7a44c66c3fd88ec16606", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                                                                                                                              WriteLiteral(equipment.EquipmentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                                                                                                                                                                      WriteLiteral(equipment.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </td>
                <td>
                    <div class=""container"">
                        <table class=""row justify-content-center"">
                            <tr>
                                <th class=""align-content-center""><img title=""Weapon Type"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/weapon_type-icon.jpg"" /></th>
                                <th><img title=""Damage Type"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/damage_type-icon.jpg"" /></th>
                                <th><img title=""Critical"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-wp_critical.png"" /></th>
                                <th><img");
            BeginWriteAttribute("title", " title=", 2487, "", 2519, 1);
#nullable restore
#line 36 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 2494, equipment.AuxEffect.Name, 2494, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=", 2519, "", 2552, 1);
#nullable restore
#line 36 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 2524, equipment.AuxEffect.IconURL, 2524, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></th>
                                <th><img title=""Weight"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon_weight.png"" /></th>
                                <th><img title=""Weapon Art"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/skill-icon.jpg"" /></th>
                                <th><img title=""FP Consumption"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon_fp_cost.png"" /></th>
                                <th><img title=""Stability"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-wp_stability.png"" /></th>
                                <th><img title=""Durability"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-durabilitiy.png"" /></th>
                            </tr>
                            <tr>
                                <td>");
#nullable restore
#line 44 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.ItemSubcategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.AttackType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.Critical);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.AuxEffectValue);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.weaponArt.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 50 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.FPConsumption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 51 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.Stability);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.Durability);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                        </table><br />
                        <table class=""row justify-content-end"">
                            <tr>
                                <th><img title=""Physical Attack"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-wp_physicalAttack.png"" /></th>
                                <th><img title=""Magic Attack"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-magicbonus.png"" /></th>
                                <th><img title=""Fire Attack"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-firebonus.png"" /></th>
                                <th><img title=""Lightning Attack"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-lightningbonus.png"" /></th>
                                <th><img title=""Dark Attack"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-darkbonus.png"" /></th>
                                <th></th>
                ");
            WriteLiteral(@"                <th><img title=""Strength Scaling"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/STR.jpg"" /></th>
                                <th><img title=""Dexterity Scaling"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/DEX.jpg"" /></th>
                                <th><img title=""Intellect Scaling"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/INT.jpg"" /></th>
                                <th><img title=""Faith Scaling"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/FTH.jpg"" /></th>
                            </tr>
                            <tr>
                                <td>");
#nullable restore
#line 69 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.PhysicalAR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 70 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.MagicAR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 71 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.FireAR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 72 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.LightningAR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 73 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.DarkAR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td></td>\r\n                                <td>");
#nullable restore
#line 75 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.StrengthScaling);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 76 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.DexterityScaling);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 77 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.IntellectScaling);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 78 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.FaithScaling);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            </tr>
                        </table><br />
                        <table class=""row justify-content-end"">
                            <tr>
                                <th><img title=""Physical Defense"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-wp_physicaldef.png"" /></th>
                                <th><img title=""Magical Defense"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-wp_magicdef.png"" /></th>
                                <th><img title=""Fire Defense"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-wp_firedef.png"" /></th>
                                <th><img title=""Lightning Defense"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-wp_lightningdef.png"" /></th>
                                <th><img title=""Dark Defense"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-wp_darkdef.png"" /></th>
                                <th></th>
        ");
            WriteLiteral(@"                        <th><img title=""Strength Requirement"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/STR.jpg"" /></th>
                                <th><img title=""Dexterity Requirement"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/DEX.jpg"" /></th>
                                <th><img title=""Intellect Requirement"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/INT.jpg"" /></th>
                                <th><img title=""Faith Requirement"" src=""https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/FTH.jpg"" /></th>
                            </tr>
                            <tr>
                                <td>");
#nullable restore
#line 95 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.PhysicalDR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 96 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.MagicDR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 97 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.FireDR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 98 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.LightningDR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 99 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.DarkDR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td></td>\r\n                                <td>");
#nullable restore
#line 101 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.StrengthRequirement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 102 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.DexterityRequirement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 103 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.IntellectRequirement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 104 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
                               Write(equipment.FaithRequirement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                        </table>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 110 "C:\Users\josha\source\repos\JoshuaAllison_TermProject\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Equipment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
