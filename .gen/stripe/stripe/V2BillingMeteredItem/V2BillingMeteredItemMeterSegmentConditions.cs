using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingMeteredItem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2BillingMeteredItem.V2BillingMeteredItemMeterSegmentConditions")]
    public class V2BillingMeteredItemMeterSegmentConditions : stripe.V2BillingMeteredItem.IV2BillingMeteredItemMeterSegmentConditions
    {
        /// <summary>A Meter dimension.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#dimension V2BillingMeteredItem#dimension}
        /// </remarks>
        [JsiiProperty(name: "dimension", typeJson: "{\"primitive\":\"string\"}")]
        public string Dimension
        {
            get;
            set;
        }

        /// <summary>To count usage towards this metered item, the dimension must have this value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_metered_item#value V2BillingMeteredItem#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
