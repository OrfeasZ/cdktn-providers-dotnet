using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingMeter
{
    [JsiiInterface(nativeType: typeof(IBillingMeterValueSettings), fullyQualifiedName: "stripe.billingMeter.BillingMeterValueSettings")]
    public interface IBillingMeterValueSettings
    {
        /// <summary>The key in the usage event payload to use as the value for this meter.</summary>
        /// <remarks>
        /// For example, if the event payload contains usage on a <c>bytes_used</c> field, then set the event_payload_key to "bytes_used".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#event_payload_key BillingMeter#event_payload_key}
        /// </remarks>
        [JsiiProperty(name: "eventPayloadKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventPayloadKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingMeterValueSettings), fullyQualifiedName: "stripe.billingMeter.BillingMeterValueSettings")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingMeter.IBillingMeterValueSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The key in the usage event payload to use as the value for this meter.</summary>
            /// <remarks>
            /// For example, if the event payload contains usage on a <c>bytes_used</c> field, then set the event_payload_key to "bytes_used".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#event_payload_key BillingMeter#event_payload_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "eventPayloadKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventPayloadKey
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
