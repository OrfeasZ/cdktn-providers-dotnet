using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingMeter
{
    [JsiiInterface(nativeType: typeof(IBillingMeterDefaultAggregation), fullyQualifiedName: "stripe.billingMeter.BillingMeterDefaultAggregation")]
    public interface IBillingMeterDefaultAggregation
    {
        /// <summary>Specifies how events are aggregated.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_meter#formula BillingMeter#formula}
        /// </remarks>
        [JsiiProperty(name: "formula", typeJson: "{\"primitive\":\"string\"}")]
        string Formula
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingMeterDefaultAggregation), fullyQualifiedName: "stripe.billingMeter.BillingMeterDefaultAggregation")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingMeter.IBillingMeterDefaultAggregation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies how events are aggregated.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_meter#formula BillingMeter#formula}
            /// </remarks>
            [JsiiProperty(name: "formula", typeJson: "{\"primitive\":\"string\"}")]
            public string Formula
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
