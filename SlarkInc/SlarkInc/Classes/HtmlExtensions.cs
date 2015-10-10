using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlarkInc.Classes
{
    public static class HtmlExtensions
    {
        /// <summary>
        /// 自定义一个@Html.Submit
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="value">value属性</param>
        /// <returns></returns>
        public static MvcHtmlString Submit(this HtmlHelper helper, string value)
        {
            var builder = new TagBuilder("input");//使我们创建的标签名字设为input。
            builder.MergeAttribute("type", "submit");//MergeAttribute函数给创建出的元素添加属性，如MergeAttribute("type", "submit") 就是加入 type="submit" 属性。
            builder.MergeAttribute("value",value);
            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));//TagRenderMode.SelfClosing使生成的标签自我关闭，也就是说有<input />这种形式。
            //最后用MvcHtmlString作为返回值是为了使返回值不被转义，比如"<"不会被转成"&lt"。这是我们不想看到的。
        }
    }
}