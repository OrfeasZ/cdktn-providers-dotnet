using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkTaxIdCollection), fullyQualifiedName: "stripe.paymentLink.PaymentLinkTaxIdCollection")]
    public interface IPaymentLinkTaxIdCollection
    {
        /// <summary>Indicates whether tax ID collection is enabled for the session.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#enabled PaymentLink#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#required PaymentLink#required}.</summary>
        [JsiiProperty(name: "required", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Required
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkTaxIdCollection), fullyQualifiedName: "stripe.paymentLink.PaymentLinkTaxIdCollection")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkTaxIdCollection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Indicates whether tax ID collection is enabled for the session.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#enabled PaymentLink#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#required PaymentLink#required}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "required", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Required
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
