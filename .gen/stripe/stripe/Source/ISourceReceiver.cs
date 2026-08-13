using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Source
{
    [JsiiInterface(nativeType: typeof(ISourceReceiver), fullyQualifiedName: "stripe.source.SourceReceiver")]
    public interface ISourceReceiver
    {
        /// <summary>Type of refund attribute method, one of `email`, `manual`, or `none`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#refund_attributes_method Source#refund_attributes_method}
        /// </remarks>
        [JsiiProperty(name: "refundAttributesMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RefundAttributesMethod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISourceReceiver), fullyQualifiedName: "stripe.source.SourceReceiver")]
        internal sealed class _Proxy : DeputyBase, stripe.Source.ISourceReceiver
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of refund attribute method, one of `email`, `manual`, or `none`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/source#refund_attributes_method Source#refund_attributes_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "refundAttributesMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RefundAttributesMethod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
