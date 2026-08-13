using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceShippingCostShippingRateData), fullyQualifiedName: "stripe.invoice.InvoiceShippingCostShippingRateData")]
    public interface IInvoiceShippingCostShippingRateData
    {
        /// <summary>The name of the shipping rate, meant to be displayable to the customer. This will appear on CheckoutSessions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#display_name Invoice#display_name}
        /// </remarks>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        string DisplayName
        {
            get;
        }

        /// <summary>The estimated range for how long shipping will take, meant to be displayable to the customer.</summary>
        /// <remarks>
        /// This will appear on CheckoutSessions.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#delivery_estimate Invoice#delivery_estimate}
        /// </remarks>
        [JsiiProperty(name: "deliveryEstimate", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimate? DeliveryEstimate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Describes a fixed amount to charge for shipping. Must be present if type is `fixed_amount`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#fixed_amount Invoice#fixed_amount}
        /// </remarks>
        [JsiiProperty(name: "fixedAmount", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataFixedAmount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoiceShippingCostShippingRateDataFixedAmount? FixedAmount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#metadata Invoice#metadata}
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

        /// <summary>Specifies whether the rate is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#tax_behavior Invoice#tax_behavior}
        /// </remarks>
        [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaxBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>A [tax code](https://docs.stripe.com/tax/tax-categories) ID. The Shipping tax code is `txcd_92010001`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#tax_code Invoice#tax_code}
        /// </remarks>
        [JsiiProperty(name: "taxCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaxCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of calculation to use on the shipping rate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#type Invoice#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoiceShippingCostShippingRateData), fullyQualifiedName: "stripe.invoice.InvoiceShippingCostShippingRateData")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceShippingCostShippingRateData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the shipping rate, meant to be displayable to the customer. This will appear on CheckoutSessions.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#display_name Invoice#display_name}
            /// </remarks>
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
            public string DisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The estimated range for how long shipping will take, meant to be displayable to the customer.</summary>
            /// <remarks>
            /// This will appear on CheckoutSessions.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#delivery_estimate Invoice#delivery_estimate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryEstimate", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimate\"}", isOptional: true)]
            public stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimate? DeliveryEstimate
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimate?>();
            }

            /// <summary>Describes a fixed amount to charge for shipping. Must be present if type is `fixed_amount`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#fixed_amount Invoice#fixed_amount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedAmount", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataFixedAmount\"}", isOptional: true)]
            public stripe.Invoice.IInvoiceShippingCostShippingRateDataFixedAmount? FixedAmount
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceShippingCostShippingRateDataFixedAmount?>();
            }

            /// <summary>Set of [key-value pairs](https://docs.stripe.com/api/metadata) that you can attach to an object. This can be useful for storing additional information about the object in a structured format. Individual keys can be unset by posting an empty value to them. All keys can be unset by posting an empty value to `metadata`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#metadata Invoice#metadata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Specifies whether the rate is considered inclusive of taxes or exclusive of taxes. One of `inclusive`, `exclusive`, or `unspecified`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#tax_behavior Invoice#tax_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A [tax code](https://docs.stripe.com/tax/tax-categories) ID. The Shipping tax code is `txcd_92010001`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#tax_code Invoice#tax_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The type of calculation to use on the shipping rate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#type Invoice#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
