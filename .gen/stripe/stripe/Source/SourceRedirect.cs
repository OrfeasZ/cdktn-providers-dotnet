using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.source.SourceRedirect")]
    public class SourceRedirect : stripe.Source.ISourceRedirect
    {
        /// <summary>The URL you provide to redirect the customer to after they authenticated their payment.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#return_url Source#return_url}
        /// </remarks>
        [JsiiProperty(name: "returnUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string ReturnUrl
        {
            get;
            set;
        }
    }
}
