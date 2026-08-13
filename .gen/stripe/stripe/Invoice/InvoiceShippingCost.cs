using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoiceShippingCost")]
    public class InvoiceShippingCost : stripe.Invoice.IInvoiceShippingCost
    {
        /// <summary>The ID of the ShippingRate for this invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#shipping_rate Invoice#shipping_rate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShippingRate
        {
            get;
            set;
        }

        /// <summary>Parameters to create a new ad-hoc shipping rate for this order.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#shipping_rate_data Invoice#shipping_rate_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shippingRateData", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateData\"}", isOptional: true)]
        public stripe.Invoice.IInvoiceShippingCostShippingRateData? ShippingRateData
        {
            get;
            set;
        }
    }
}
