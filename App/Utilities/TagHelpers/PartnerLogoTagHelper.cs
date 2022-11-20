using Microsoft.AspNetCore.Razor.TagHelpers;

namespace App.Utilities.TagHelpers;

[HtmlTargetElement("partner-logo", TagStructure = TagStructure.WithoutEndTag)]
public class PartnerLogoTagHelper : TagHelper
{
    private readonly string _imageUrl;

    public int Id { get; set; }
    public string Alt { get; set; } = default!;
    public string Class { get; set; } = default!;

    public PartnerLogoTagHelper(IConfiguration configuration)
    {
        var imageUrl = configuration.GetValue<string>("ApiConfiguration:PartnerLogo");
        if (imageUrl is null) throw new Exception("Parter logo was null in the configuration file.");
        _imageUrl = imageUrl;
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "img";
        output.TagMode = TagMode.SelfClosing;
        output.Attributes.Add("src", string.Format(_imageUrl, Id));
        output.Attributes.Add("alt", Alt);
        output.Attributes.Add("class", Class);
    }
}
