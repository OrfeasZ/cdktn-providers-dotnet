using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingMeteredItem
{
    [JsiiInterface(nativeType: typeof(IV2BillingMeteredItemMeterSegmentConditions), fullyQualifiedName: "stripe.v2BillingMeteredItem.V2BillingMeteredItemMeterSegmentConditions")]
    public interface IV2BillingMeteredItemMeterSegmentConditions
    {
        /// <summary>A Meter dimension.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#dimension V2BillingMeteredItem#dimension}
        /// </remarks>
        [JsiiProperty(name: "dimension", typeJson: "{\"primitive\":\"string\"}")]
        string Dimension
        {
            get;
        }

        /// <summary>To count usage towards this metered item, the dimension must have this value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#value V2BillingMeteredItem#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IV2BillingMeteredItemMeterSegmentConditions), fullyQualifiedName: "stripe.v2BillingMeteredItem.V2BillingMeteredItemMeterSegmentConditions")]
        internal sealed class _Proxy : DeputyBase, stripe.V2BillingMeteredItem.IV2BillingMeteredItemMeterSegmentConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A Meter dimension.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#dimension V2BillingMeteredItem#dimension}
            /// </remarks>
            [JsiiProperty(name: "dimension", typeJson: "{\"primitive\":\"string\"}")]
            public string Dimension
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>To count usage towards this metered item, the dimension must have this value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#value V2BillingMeteredItem#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
