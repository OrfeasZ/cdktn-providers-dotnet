using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingMeter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.billingMeter.BillingMeterCustomerMapping")]
    public class BillingMeterCustomerMapping : stripe.BillingMeter.IBillingMeterCustomerMapping
    {
        /// <summary>The key in the meter event payload to use for mapping the event to a customer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#event_payload_key BillingMeter#event_payload_key}
        /// </remarks>
        [JsiiProperty(name: "eventPayloadKey", typeJson: "{\"primitive\":\"string\"}")]
        public string EventPayloadKey
        {
            get;
            set;
        }

        /// <summary>The method for mapping a meter event to a customer. Must be `by_id`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#type BillingMeter#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
