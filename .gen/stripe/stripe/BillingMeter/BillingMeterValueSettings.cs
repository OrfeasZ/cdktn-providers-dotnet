using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingMeter
{
    [JsiiByValue(fqn: "stripe.billingMeter.BillingMeterValueSettings")]
    public class BillingMeterValueSettings : stripe.BillingMeter.IBillingMeterValueSettings
    {
        /// <summary>The key in the meter event payload to use as the value for this meter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_meter#event_payload_key BillingMeter#event_payload_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "eventPayloadKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EventPayloadKey
        {
            get;
            set;
        }
    }
}
