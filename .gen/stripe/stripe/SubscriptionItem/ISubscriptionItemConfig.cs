using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionItem
{
    [JsiiInterface(nativeType: typeof(ISubscriptionItemConfig), fullyQualifiedName: "stripe.subscriptionItem.SubscriptionItemConfig")]
    public interface ISubscriptionItemConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The `subscription` this `subscription_item` belongs to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#subscription SubscriptionItem#subscription}
        /// </remarks>
        [JsiiProperty(name: "subscription", typeJson: "{\"primitive\":\"string\"}")]
        string Subscription
        {
            get;
        }

        /// <summary>Define thresholds at which an invoice will be sent, and the related subscription advanced to a new billing period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#billing_thresholds SubscriptionItem#billing_thresholds}
        /// </remarks>
        [JsiiProperty(name: "billingThresholds", typeJson: "{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemBillingThresholds\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionItem.ISubscriptionItemBillingThresholds? BillingThresholds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The discounts applied to the subscription item.</summary>
        /// <remarks>
        /// Subscription item discounts are applied before subscription discounts. Use <c>expand[]=discounts</c> to expand each discount.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#discounts SubscriptionItem#discounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionItem.ISubscriptionItemDiscounts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Discounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#metadata SubscriptionItem#metadata}
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls how Stripe handles payment when a subscription update requires payment and `collection_method=charge_automatically`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#payment_behavior SubscriptionItem#payment_behavior}
        /// </remarks>
        [JsiiProperty(name: "paymentBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PaymentBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>You can now model subscriptions more flexibly using the [Prices API](https://api.stripe.com#prices). It replaces the Plans API and is backwards compatible to simplify your migration.</summary>
        /// <remarks>
        /// Plans define the base price, currency, and billing cycle for recurring purchases of products.
        /// <a href="https://api.stripe.com#products">Products</a> help you track inventory or provisioning, and plans help you track pricing. Different physical goods or levels of service should be represented by products, and pricing options should be represented by plans. This approach lets you change prices without having to change your provisioning scheme.
        ///
        /// For example, you might have a single "gold" product that has plans for $10/month, $100/year, €9/month, and €90/year.
        ///
        /// Related guides: <a href="https://docs.stripe.com/billing/subscriptions/set-up-subscription">Set up a subscription</a> and more about <a href="https://docs.stripe.com/products-prices/overview">products and prices</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#plan SubscriptionItem#plan}
        /// </remarks>
        [JsiiProperty(name: "plan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Plan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Prices define the unit cost, currency, and (optional) billing cycle for both recurring and one-time purchases of products.</summary>
        /// <remarks>
        /// <a href="https://api.stripe.com#products">Products</a> help you track inventory or provisioning, and prices help you track payment terms. Different physical goods or levels of service should be represented by products, and pricing options should be represented by prices. This approach lets you change prices without having to change your provisioning scheme.
        ///
        /// For example, you might have a single "gold" product that has prices for $10/month, $100/year, and €9 once.
        ///
        /// Related guides: <a href="https://docs.stripe.com/billing/subscriptions/set-up-subscription">Set up a subscription</a>, <a href="https://docs.stripe.com/billing/invoices/create">create an invoice</a>, and more about <a href="https://docs.stripe.com/products-prices/overview">products and prices</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#price SubscriptionItem#price}
        /// </remarks>
        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Price
        {
            get
            {
                return null;
            }
        }

        /// <summary>Data used to generate a new [Price](https://docs.stripe.com/api/prices) object inline.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#price_data SubscriptionItem#price_data}
        /// </remarks>
        [JsiiProperty(name: "priceData", typeJson: "{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemPriceData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionItem.ISubscriptionItemPriceData? PriceData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines how to handle [prorations](https://docs.stripe.com/billing/subscriptions/prorations) when the billing cycle changes (e.g., when switching plans, resetting `billing_cycle_anchor=now`, or starting a trial), or if an item's `quantity` changes. The default value is `create_prorations`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#proration_behavior SubscriptionItem#proration_behavior}
        /// </remarks>
        [JsiiProperty(name: "prorationBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProrationBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set, the proration will be calculated as though the subscription was updated at the given time.</summary>
        /// <remarks>
        /// This can be used to apply the same proration that was previewed with the <a href="/api/invoices/create_preview">upcoming invoice</a> endpoint.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#proration_date SubscriptionItem#proration_date}
        /// </remarks>
        [JsiiProperty(name: "prorationDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ProrationDate
        {
            get
            {
                return null;
            }
        }

        /// <summary>The [quantity](https://docs.stripe.com/subscriptions/quantities) of the plan to which the customer should be subscribed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#quantity SubscriptionItem#quantity}
        /// </remarks>
        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Quantity
        {
            get
            {
                return null;
            }
        }

        /// <summary>The tax rates which apply to this `subscription_item`.</summary>
        /// <remarks>
        /// When set, the <c>default_tax_rates</c> on the subscription do not apply to this <c>subscription_item</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#tax_rates SubscriptionItem#tax_rates}
        /// </remarks>
        [JsiiProperty(name: "taxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TaxRates
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionItemConfig), fullyQualifiedName: "stripe.subscriptionItem.SubscriptionItemConfig")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionItem.ISubscriptionItemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The `subscription` this `subscription_item` belongs to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#subscription SubscriptionItem#subscription}
            /// </remarks>
            [JsiiProperty(name: "subscription", typeJson: "{\"primitive\":\"string\"}")]
            public string Subscription
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Define thresholds at which an invoice will be sent, and the related subscription advanced to a new billing period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#billing_thresholds SubscriptionItem#billing_thresholds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingThresholds", typeJson: "{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemBillingThresholds\"}", isOptional: true)]
            public stripe.SubscriptionItem.ISubscriptionItemBillingThresholds? BillingThresholds
            {
                get => GetInstanceProperty<stripe.SubscriptionItem.ISubscriptionItemBillingThresholds?>();
            }

            /// <summary>The discounts applied to the subscription item.</summary>
            /// <remarks>
            /// Subscription item discounts are applied before subscription discounts. Use <c>expand[]=discounts</c> to expand each discount.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#discounts SubscriptionItem#discounts}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionItem.ISubscriptionItemDiscounts" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Discounts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#metadata SubscriptionItem#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Controls how Stripe handles payment when a subscription update requires payment and `collection_method=charge_automatically`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#payment_behavior SubscriptionItem#payment_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paymentBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PaymentBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>You can now model subscriptions more flexibly using the [Prices API](https://api.stripe.com#prices). It replaces the Plans API and is backwards compatible to simplify your migration.</summary>
            /// <remarks>
            /// Plans define the base price, currency, and billing cycle for recurring purchases of products.
            /// <a href="https://api.stripe.com#products">Products</a> help you track inventory or provisioning, and plans help you track pricing. Different physical goods or levels of service should be represented by products, and pricing options should be represented by plans. This approach lets you change prices without having to change your provisioning scheme.
            ///
            /// For example, you might have a single "gold" product that has plans for $10/month, $100/year, €9/month, and €90/year.
            ///
            /// Related guides: <a href="https://docs.stripe.com/billing/subscriptions/set-up-subscription">Set up a subscription</a> and more about <a href="https://docs.stripe.com/products-prices/overview">products and prices</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#plan SubscriptionItem#plan}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "plan", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Plan
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Prices define the unit cost, currency, and (optional) billing cycle for both recurring and one-time purchases of products.</summary>
            /// <remarks>
            /// <a href="https://api.stripe.com#products">Products</a> help you track inventory or provisioning, and prices help you track payment terms. Different physical goods or levels of service should be represented by products, and pricing options should be represented by prices. This approach lets you change prices without having to change your provisioning scheme.
            ///
            /// For example, you might have a single "gold" product that has prices for $10/month, $100/year, and €9 once.
            ///
            /// Related guides: <a href="https://docs.stripe.com/billing/subscriptions/set-up-subscription">Set up a subscription</a>, <a href="https://docs.stripe.com/billing/invoices/create">create an invoice</a>, and more about <a href="https://docs.stripe.com/products-prices/overview">products and prices</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#price SubscriptionItem#price}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Price
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Data used to generate a new [Price](https://docs.stripe.com/api/prices) object inline.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#price_data SubscriptionItem#price_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priceData", typeJson: "{\"fqn\":\"stripe.subscriptionItem.SubscriptionItemPriceData\"}", isOptional: true)]
            public stripe.SubscriptionItem.ISubscriptionItemPriceData? PriceData
            {
                get => GetInstanceProperty<stripe.SubscriptionItem.ISubscriptionItemPriceData?>();
            }

            /// <summary>Determines how to handle [prorations](https://docs.stripe.com/billing/subscriptions/prorations) when the billing cycle changes (e.g., when switching plans, resetting `billing_cycle_anchor=now`, or starting a trial), or if an item's `quantity` changes. The default value is `create_prorations`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#proration_behavior SubscriptionItem#proration_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prorationBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProrationBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>If set, the proration will be calculated as though the subscription was updated at the given time.</summary>
            /// <remarks>
            /// This can be used to apply the same proration that was previewed with the <a href="/api/invoices/create_preview">upcoming invoice</a> endpoint.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#proration_date SubscriptionItem#proration_date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prorationDate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ProrationDate
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The [quantity](https://docs.stripe.com/subscriptions/quantities) of the plan to which the customer should be subscribed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#quantity SubscriptionItem#quantity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Quantity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The tax rates which apply to this `subscription_item`.</summary>
            /// <remarks>
            /// When set, the <c>default_tax_rates</c> on the subscription do not apply to this <c>subscription_item</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_item#tax_rates SubscriptionItem#tax_rates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TaxRates
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
