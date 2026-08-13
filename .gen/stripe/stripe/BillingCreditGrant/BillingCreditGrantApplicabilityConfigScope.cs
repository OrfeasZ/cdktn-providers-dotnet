using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingCreditGrant
{
    [JsiiByValue(fqn: "stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigScope")]
    public class BillingCreditGrantApplicabilityConfigScope : stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScope
    {
        private object? _prices;

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
            get => _prices;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScopePrices[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfigScopePrices).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _prices = value;
            }
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
            get;
            set;
        }
    }
}
