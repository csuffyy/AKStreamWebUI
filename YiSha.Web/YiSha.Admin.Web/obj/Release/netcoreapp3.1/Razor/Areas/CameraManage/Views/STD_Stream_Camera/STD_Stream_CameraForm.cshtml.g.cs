#pragma checksum "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\STD_Stream_Camera\STD_Stream_CameraForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a694ec53631e346eb946a9cbebeb69712b262896"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_CameraManage_Views_STD_Stream_Camera_STD_Stream_CameraForm), @"mvc.1.0.view", @"/Areas/CameraManage/Views/STD_Stream_Camera/STD_Stream_CameraForm.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 3 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a694ec53631e346eb946a9cbebeb69712b262896", @"/Areas/CameraManage/Views/STD_Stream_Camera/STD_Stream_CameraForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b622e924f35698514110c8d85c04ddd5a27d39", @"/Areas/CameraManage/_ViewImports.cshtml")]
    public class Areas_CameraManage_Views_STD_Stream_Camera_STD_Stream_CameraForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal m"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\STD_Stream_Camera\STD_Stream_CameraForm.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a694ec53631e346eb946a9cbebeb69712b2628965258", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">设备ID<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""cameraId"" col=""CameraId"" type=""text"" class=""form-control"" disabled />
            </div>
            <label class=""col-sm-2 control-label "">台账ID<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""spjkTZID"" col=""SpjkTZID"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">设备名称<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""cameraName"" col=""CameraName"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">设备IP<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""cameraIpAddress"" col=""CameraIpAddress"" type=""text"" class=""f");
                WriteLiteral(@"orm-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">公司ID</label>
            <div class=""col-sm-4"">
                <input id=""deptId"" col=""DeptId"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">公司名称</label>
            <div class=""col-sm-4"">
                <input id=""deptName"" col=""DeptName"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">部门ID</label>
            <div class=""col-sm-4"">
                <input id=""pDetpId"" col=""PDetpId"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">部门名称</label>
            <div class=""col-sm-4"">
                <input id=""pDetpName"" col=""PDetpName"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
 ");
                WriteLiteral(@"           <label class=""col-sm-2 control-label "">Device ID<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""cameraDeviceLable"" col=""CameraDeviceLable"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">Channel ID<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""cameraChannelLable"" col=""CameraChannelLable"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">Rtsp地址</label>
            <div class=""col-sm-4"">
                <input id=""ifRtspUrl"" col=""IfRtspUrl"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">流媒体服务<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""pushMediaServerId"" col=""PushMediaServerId""></div>
            </div>
        </div");
                WriteLiteral(@">
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">TCP协议<font class=""red""> *</font></label>
            <div class=""col-sm-4"" id=""ifGb28181Tcp"" col=""IfGb28181Tcp""></div>
            <label class=""col-sm-2 control-label "">设备类型<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""cameraType"" col=""CameraType""></div>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">启用云台<font class=""red""> *</font></label>
            <div class=""col-sm-4"" id=""enablePtz"" col=""EnablePtz""></div>
            <label class=""col-sm-2 control-label "">移动设备<font class=""red""> *</font></label>
            <div class=""col-sm-4"" id=""mobileCamera"" col=""MobileCamera""></div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">启用直播<font class=""red""> *</font></label>
            <div class=""col-sm-4"" id=""enableLive"" col=""EnableLive""></div>
  ");
                WriteLiteral("          <label class=\"col-sm-2 control-label \">激活状态<font class=\"red\"> *</font></label>\r\n            <div class=\"col-sm-4\" id=\"activated\" col=\"Activated\"></div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    var id = ys.request(\"id\");\r\n    $(function () {\r\n        $(\"#enableLive\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 93 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\STD_Stream_Camera\STD_Stream_CameraForm.cshtml"
                                                  Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#enablePtz\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 94 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\STD_Stream_Camera\STD_Stream_CameraForm.cshtml"
                                                 Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#activated\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 95 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\STD_Stream_Camera\STD_Stream_CameraForm.cshtml"
                                                 Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#mobileCamera\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 96 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\STD_Stream_Camera\STD_Stream_CameraForm.cshtml"
                                                    Write(Html.Raw(typeof(IsEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#ifGb28181Tcp\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 97 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\STD_Stream_Camera\STD_Stream_CameraForm.cshtml"
                                                    Write(Html.Raw(typeof(IsEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@") });

        $(""#cameraType"").ysComboBox({
            data: top.getDataDict(""cameraType""),
            key: ""DictKey"",
            value: ""DictValue"",
            class: ""form-control""
        });

        $(""#pushMediaServerId"").ysComboBox({
            url: '");
#nullable restore
#line 107 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\STD_Stream_Camera\STD_Stream_CameraForm.cshtml"
             Write(Url.Content("~/CameraManage/STD_Stream_Camera/GetPushMediaList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            key: ""mediaServerId"",
            value: ""mediaServerId"",
            class: ""form-control""
        });

        getForm();

        $('#form').validate({
            rules: {
                cameraId: { required: true }
            }
        });
    });

    function getForm() {
        if (id > 0) {
            ys.ajax({
                url: '");
#nullable restore
#line 125 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\STD_Stream_Camera\STD_Stream_CameraForm.cshtml"
                 Write(Url.Content("~/CameraManage/STD_Stream_Camera/GetFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
                type: 'get',
                success: function (obj) {
                    if (obj.Tag == 1) {
                        obj.Data.EnableLive = obj.Data.EnableLive == true ? 1 : 0;
                        obj.Data.EnablePtz = obj.Data.EnablePtz == true ? 1 : 0;
                        obj.Data.Activated = obj.Data.Activated == true ? 1 : 0;
                        obj.Data.MobileCamera = obj.Data.MobileCamera == true ? 1 : 0;
                        obj.Data.IfGb28181Tcp = obj.Data.IfGb28181Tcp == true ? 1 : 0;
                        $('#form').setWebControls(obj.Data);
                    }
                }
            });
        }
        else {
            var defaultData = {};
            $('#form').setWebControls(defaultData);
        }
    }

    function saveForm(index) {
        if ($('#form').validate().form()) {
            var postData = $('#form').getWebControls({ Id: id });
            ys.ajax({
                url: '");
#nullable restore
#line 149 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\STD_Stream_Camera\STD_Stream_CameraForm.cshtml"
                 Write(Url.Content("~/CameraManage/STD_Stream_Camera/SaveFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'post',
                data: postData,
                success: function (obj) {
                    if (obj.Tag == 1) {
                        ys.msgSuccess(obj.Message);
                        parent.searchGrid();
                        parent.layer.close(index);
                    }
                    else {
                        ys.msgError(obj.Message);
                    }
                }
            });
        }
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
