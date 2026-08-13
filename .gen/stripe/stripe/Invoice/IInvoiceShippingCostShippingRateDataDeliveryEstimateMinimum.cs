using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceShippingCostShippingRateDataDeliveryEstimateMinimum), fullyQualifiedName: "stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMinimum")]
    public interface IInvoiceShippingCostShippingRateDataDeliveryEstimateMinimum
    {
        /// <summary>A unit of time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#unit Invoice#unit}
        /// </remarks>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        string Unit
        {
            get;
        }

        /// <summary>Must be greater than 0.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#value Invoice#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoiceShippingCostShippingRateDataDeliveryEstimateMinimum), fullyQualifiedName: "stripe.invoice.InvoiceShippingCostShippingRateDataDeliveryEstimateMinimum")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceShippingCostShippingRateDataDeliveryEstimateMinimum
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A unit of time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#unit Invoice#unit}
            /// </remarks>
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
            public string Unit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Must be greater than 0.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#value Invoice#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
