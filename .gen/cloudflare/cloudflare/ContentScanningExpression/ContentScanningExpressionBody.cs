using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ContentScanningExpression
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.contentScanningExpression.ContentScanningExpressionBody")]
    public class ContentScanningExpressionBody : cloudflare.ContentScanningExpression.IContentScanningExpressionBody
    {
        /// <summary>Defines the ruleset expression to use in matching content objects.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/content_scanning_expression#payload ContentScanningExpression#payload}
        /// </remarks>
        [JsiiProperty(name: "payload", typeJson: "{\"primitive\":\"string\"}")]
        public string Payload
        {
            get;
            set;
        }
    }
}
