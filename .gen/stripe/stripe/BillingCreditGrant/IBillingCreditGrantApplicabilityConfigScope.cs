using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingCreditGrant
{
    [JsiiInterface(nativeType: typeof(IBillingCreditGrantApplicabilityConfigScope), fullyQualifiedName: "stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScope")]
    public interface IBillingCreditGrantApplicabilityConfigScope
    {
        /// <summary>The prices that credit grants can apply to.</summary>
        /// <remarks>
        /// We currently only support <c>metered</c> prices. This refers to prices that have a <a href="https://docs.stripe.com/api/billing/meter">Billing Meter</a> attached to them. Cannot be used in combination with <c>price_type</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#prices BillingCreditGrant#prices}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScopePrices" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "prices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScopePrices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Prices
        {
            get
            {
                return null;
            }
        }

        /// <summary>The price type that credit grants can apply to.</summary>
        /// <remarks>
        /// We currently only support the <c>metered</c> price type. This refers to prices that have a <a href="https://docs.stripe.com/api/billing/meter">Billing Meter</a> attached to them. Cannot be used in combination with <c>prices</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#price_type BillingCreditGrant#price_type}
        /// </remarks>
        [JsiiProperty(name: "priceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PriceType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingCreditGrantApplicabilityConfigScope), fullyQualifiedName: "stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScope")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The prices that credit grants can apply to.</summary>
            /// <remarks>
            /// We currently only support <c>metered</c> prices. This refers to prices that have a <a href="https://docs.stripe.com/api/billing/meter">Billing Meter</a> attached to them. Cannot be used in combination with <c>price_type</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#prices BillingCreditGrant#prices}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScopePrices" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScopePrices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Prices
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The price type that credit grants can apply to.</summary>
            /// <remarks>
            /// We currently only support the <c>metered</c> price type. This refers to prices that have a <a href="https://docs.stripe.com/api/billing/meter">Billing Meter</a> attached to them. Cannot be used in combination with <c>prices</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#price_type BillingCreditGrant#price_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PriceType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
