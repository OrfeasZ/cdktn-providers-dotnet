using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingMeter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.billingMeter.BillingMeterDefaultAggregation")]
    public class BillingMeterDefaultAggregation : stripe.BillingMeter.IBillingMeterDefaultAggregation
    {
        /// <summary>Specifies how events are aggregated.</summary>
        /// <remarks>
        /// Allowed values are <c>count</c> to count the number of events, <c>sum</c> to sum each event's value and <c>last</c> to take the last event's value in the window.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#formula BillingMeter#formula}
        /// </remarks>
        [JsiiProperty(name: "formula", typeJson: "{\"primitive\":\"string\"}")]
        public string Formula
        {
            get;
            set;
        }
    }
}
