using _413Final_Blosil.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _413Final_Blosil.Infrastructure;

public class PaginationTagHelper
{
    private IUrlHelperFactory UrlHelperFactory;

    public PaginationTagHelper(IUrlHelperFactory temp)
    {
        UrlHelperFactory = temp;
    }
    
    [ViewContext]
    [HtmlAttributeNotBound]
    public ViewContext? ViewContext { get; set; }
    public string? PageAction { get; set; }
    public PaginationInfo PageModel { get; set; }
    public bool PageClassEnabled { get; set; } = false;
    public string PageClass { get; set; } = String.Empty;
    public string PageClassNormal { get; set; } = String.Empty;
    public string PageClassSelected { get; set; } = String.Empty;

    public void Process(TagHelperContext context, TagHelperOutput output)
    {
        if (ViewContext != null && PageModel != null)
        {
            IUrlHelper urlHelper = UrlHelperFactory.GetUrlHelper(ViewContext);

            TagBuilder result = new TagBuilder("div");

            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.Attributes["href"] = urlHelper.Action(PageAction, new { pageNum = i });
                if (PageClassEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);
                }
                tag.InnerHtml.Append(i.ToString());

                result.InnerHtml.AppendHtml(tag);
            }

            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}