using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceShippingCost), fullyQualifiedName: "stripe.invoice.InvoiceShippingCost")]
    public interface IInvoiceShippingCost
    {
        /// <summary>The ID of the ShippingRate for this invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#shipping_rate Invoice#shipping_rate}
        /// </remarks>
        [JsiiProperty(name: "shippingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShippingRate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Parameters to create a new ad-hoc shipping rate for this order.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#shipping_rate_data Invoice#shipping_rate_data}
        /// </remarks>
        [JsiiProperty(name: "shippingRateData", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Invoice.IInvoiceShippingCostShippingRateData? ShippingRateData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoiceShippingCost), fullyQualifiedName: "stripe.invoice.InvoiceShippingCost")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceShippingCost
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the ShippingRate for this invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#shipping_rate Invoice#shipping_rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shippingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShippingRate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Parameters to create a new ad-hoc shipping rate for this order.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#shipping_rate_data Invoice#shipping_rate_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shippingRateData", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateData\"}", isOptional: true)]
            public stripe.Invoice.IInvoiceShippingCostShippingRateData? ShippingRateData
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceShippingCostShippingRateData?>();
            }
        }
    }
}
