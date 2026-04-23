using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BillingView
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.billingView.BillingViewDataFilterExpressionTimeRange")]
    public class BillingViewDataFilterExpressionTimeRange : aws.BillingView.IBillingViewDataFilterExpressionTimeRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/billing_view#begin_date_inclusive BillingView#begin_date_inclusive}.</summary>
        [JsiiProperty(name: "beginDateInclusive", typeJson: "{\"primitive\":\"string\"}")]
        public string BeginDateInclusive
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/billing_view#end_date_inclusive BillingView#end_date_inclusive}.</summary>
        [JsiiProperty(name: "endDateInclusive", typeJson: "{\"primitive\":\"string\"}")]
        public string EndDateInclusive
        {
            get;
            set;
        }
    }
}
