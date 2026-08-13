using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMaximum")]
    public class InvoiceShippingCostShippingRateDataDeliveryEstimateMaximum : stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimateMaximum
    {
        /// <summary>A unit of time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#unit Invoice#unit}
        /// </remarks>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        public string Unit
        {
            get;
            set;
        }

        /// <summary>Must be greater than 0.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#value Invoice#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }
    }
}
