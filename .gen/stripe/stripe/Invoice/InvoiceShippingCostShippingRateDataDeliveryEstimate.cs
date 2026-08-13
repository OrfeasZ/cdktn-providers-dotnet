using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiByValue(fqn: "stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimate")]
    public class InvoiceShippingCostShippingRateDataDeliveryEstimate : stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimate
    {
        /// <summary>The upper bound of the estimated range. If empty, represents no upper bound i.e., infinite.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#maximum Invoice#maximum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maximum", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMaximum\"}", isOptional: true)]
        public stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimateMaximum? Maximum
        {
            get;
            set;
        }

        /// <summary>The lower bound of the estimated range. If empty, represents no lower bound.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#minimum Invoice#minimum}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minimum", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMinimum\"}", isOptional: true)]
        public stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimateMinimum? Minimum
        {
            get;
            set;
        }
    }
}
