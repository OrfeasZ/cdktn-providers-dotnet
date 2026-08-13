using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkAutomaticTax), fullyQualifiedName: "stripe.paymentLink.PaymentLinkAutomaticTax")]
    public interface IPaymentLinkAutomaticTax
    {
        /// <summary>If `true`, tax will be calculated automatically using the customer's location.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#enabled PaymentLink#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>The account that's liable for tax.</summary>
        /// <remarks>
        /// If set, the business address and tax registrations required to perform the tax calculation are loaded from this account. The tax transaction is returned in the report of the connected account.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#liability PaymentLink#liability}
        /// </remarks>
        [JsiiProperty(name: "liability", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAutomaticTaxLiability\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkAutomaticTaxLiability? Liability
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkAutomaticTax), fullyQualifiedName: "stripe.paymentLink.PaymentLinkAutomaticTax")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkAutomaticTax
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If `true`, tax will be calculated automatically using the customer's location.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#enabled PaymentLink#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The account that's liable for tax.</summary>
            /// <remarks>
            /// If set, the business address and tax registrations required to perform the tax calculation are loaded from this account. The tax transaction is returned in the report of the connected account.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#liability PaymentLink#liability}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "liability", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkAutomaticTaxLiability\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkAutomaticTaxLiability? Liability
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkAutomaticTaxLiability?>();
            }
        }
    }
}
