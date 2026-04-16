using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingMeter
{
    [JsiiInterface(nativeType: typeof(IBillingMeterCustomerMapping), fullyQualifiedName: "stripe.billingMeter.BillingMeterCustomerMapping")]
    public interface IBillingMeterCustomerMapping
    {
        /// <summary>The key in the meter event payload to use for mapping the event to a customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#event_payload_key BillingMeter#event_payload_key}
        /// </remarks>
        [JsiiProperty(name: "eventPayloadKey", typeJson: "{\"primitive\":\"string\"}")]
        string EventPayloadKey
        {
            get;
        }

        /// <summary>The method for mapping a meter event to a customer. Must be `by_id`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#type BillingMeter#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingMeterCustomerMapping), fullyQualifiedName: "stripe.billingMeter.BillingMeterCustomerMapping")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingMeter.IBillingMeterCustomerMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The key in the meter event payload to use for mapping the event to a customer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#event_payload_key BillingMeter#event_payload_key}
            /// </remarks>
            [JsiiProperty(name: "eventPayloadKey", typeJson: "{\"primitive\":\"string\"}")]
            public string EventPayloadKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The method for mapping a meter event to a customer. Must be `by_id`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#type BillingMeter#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
