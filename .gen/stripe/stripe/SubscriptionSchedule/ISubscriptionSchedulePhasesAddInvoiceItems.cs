using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiInterface(nativeType: typeof(ISubscriptionSchedulePhasesAddInvoiceItems), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItems")]
    public interface ISubscriptionSchedulePhasesAddInvoiceItems
    {
        /// <summary>Controls whether discounts apply to this invoice item. Defaults to true if no value is provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#discountable SubscriptionSchedule#discountable}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "discountable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Discountable
        {
            get
            {
                return null;
            }
        }

        /// <summary>The stackable discounts that will be applied to the item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#discounts SubscriptionSchedule#discounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsDiscounts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#metadata SubscriptionSchedule#metadata}
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#period SubscriptionSchedule#period}.</summary>
        [JsiiProperty(name: "period", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriod? Period
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the price used to generate the invoice item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#price SubscriptionSchedule#price}
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

        /// <summary>Data used to generate a new [Price](https://docs.stripe.com/api/prices) object inline. One of `price` or `price_data` is required.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#price_data SubscriptionSchedule#price_data}
        /// </remarks>
        [JsiiProperty(name: "priceData", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPriceData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPriceData? PriceData
        {
            get
            {
                return null;
            }
        }

        /// <summary>The quantity of the invoice item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#quantity SubscriptionSchedule#quantity}
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

        /// <summary>The tax rates which apply to the item. When set, the `default_tax_rates` do not apply to this item.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#tax_rates SubscriptionSchedule#tax_rates}
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

        [JsiiTypeProxy(nativeType: typeof(ISubscriptionSchedulePhasesAddInvoiceItems), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItems")]
        internal sealed class _Proxy : DeputyBase, stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Controls whether discounts apply to this invoice item. Defaults to true if no value is provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#discountable SubscriptionSchedule#discountable}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discountable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Discountable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The stackable discounts that will be applied to the item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#discounts SubscriptionSchedule#discounts}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsDiscounts" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsDiscounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Discounts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#metadata SubscriptionSchedule#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#period SubscriptionSchedule#period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "period", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPeriod\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriod? Period
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPeriod?>();
            }

            /// <summary>ID of the price used to generate the invoice item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#price SubscriptionSchedule#price}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Price
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Data used to generate a new [Price](https://docs.stripe.com/api/prices) object inline. One of `price` or `price_data` is required.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#price_data SubscriptionSchedule#price_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "priceData", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesAddInvoiceItemsPriceData\"}", isOptional: true)]
            public stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPriceData? PriceData
            {
                get => GetInstanceProperty<stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesAddInvoiceItemsPriceData?>();
            }

            /// <summary>The quantity of the invoice item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#quantity SubscriptionSchedule#quantity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Quantity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The tax rates which apply to the item. When set, the `default_tax_rates` do not apply to this item.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#tax_rates SubscriptionSchedule#tax_rates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxRates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TaxRates
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
