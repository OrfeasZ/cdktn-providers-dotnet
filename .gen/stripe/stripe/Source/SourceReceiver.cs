using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiByValue(fqn: "stripe.source.SourceReceiver")]
    public class SourceReceiver : stripe.Source.ISourceReceiver
    {
        /// <summary>Type of refund attribute method, one of `email`, `manual`, or `none`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#refund_attributes_method Source#refund_attributes_method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "refundAttributesMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RefundAttributesMethod
        {
            get;
            set;
        }
    }
}
