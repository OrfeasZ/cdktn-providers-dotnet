using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BillingView
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.billingView.BillingViewDataFilterExpressionTags")]
    public class BillingViewDataFilterExpressionTags : aws.BillingView.IBillingViewDataFilterExpressionTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/billing_view#key BillingView#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/billing_view#values BillingView#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
