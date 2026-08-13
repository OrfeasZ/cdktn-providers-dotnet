using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Subscription
{
    [JsiiByValue(fqn: "stripe.subscription.SubscriptionItems")]
    public class SubscriptionItems : stripe.Subscription.ISubscriptionItems
    {
        /// <summary>Define thresholds at which an invoice will be sent, and the subscription advanced to a new billing period.</summary>
        /// <remarks>
        /// Pass an empty string to remove previously-defined thresholds.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#billing_thresholds Subscription#billing_thresholds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingThresholds", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionItemsBillingThresholds\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionItemsBillingThresholds? BillingThresholds
        {
            get;
            set;
        }

        private object? _discounts;

        /// <summary>The coupons to redeem into discounts for the subscription item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#discounts Subscription#discounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Subscription.ISubscriptionItemsDiscounts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscription.SubscriptionItemsDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Discounts
        {
            get => _discounts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Subscription.ISubscriptionItemsDiscounts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Subscription.ISubscriptionItemsDiscounts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _discounts = value;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#metadata Subscription#metadata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>The ID of the price object.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#price Subscription#price}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Price
        {
            get;
            set;
        }

        /// <summary>Data used to generate a new [Price](https://docs.stripe.com/api/prices) object inline.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#price_data Subscription#price_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "priceData", typeJson: "{\"fqn\":\"stripe.subscription.SubscriptionItemsPriceData\"}", isOptional: true)]
        public stripe.Subscription.ISubscriptionItemsPriceData? PriceData
        {
            get;
            set;
        }

        /// <summary>Quantity for this item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#quantity Subscription#quantity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Quantity
        {
            get;
            set;
        }

        /// <summary>A list of [Tax Rate](https://docs.stripe.com/api/tax_rates) ids. These Tax Rates will override the [`default_tax_rates`](https://docs.stripe.com/api/subscriptions/create#create_subscription-default_tax_rates) on the Subscription. When updating, pass an empty string to remove previously-defined tax rates.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription#tax_rates Subscription#tax_rates}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TaxRates
        {
            get;
            set;
        }
    }
}
