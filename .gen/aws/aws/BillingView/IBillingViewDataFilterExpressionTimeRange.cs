using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BillingView
{
    [JsiiInterface(nativeType: typeof(IBillingViewDataFilterExpressionTimeRange), fullyQualifiedName: "aws.billingView.BillingViewDataFilterExpressionTimeRange")]
    public interface IBillingViewDataFilterExpressionTimeRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/billing_view#begin_date_inclusive BillingView#begin_date_inclusive}.</summary>
        [JsiiProperty(name: "beginDateInclusive", typeJson: "{\"primitive\":\"string\"}")]
        string BeginDateInclusive
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/billing_view#end_date_inclusive BillingView#end_date_inclusive}.</summary>
        [JsiiProperty(name: "endDateInclusive", typeJson: "{\"primitive\":\"string\"}")]
        string EndDateInclusive
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingViewDataFilterExpressionTimeRange), fullyQualifiedName: "aws.billingView.BillingViewDataFilterExpressionTimeRange")]
        internal sealed class _Proxy : DeputyBase, aws.BillingView.IBillingViewDataFilterExpressionTimeRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/billing_view#begin_date_inclusive BillingView#begin_date_inclusive}.</summary>
            [JsiiProperty(name: "beginDateInclusive", typeJson: "{\"primitive\":\"string\"}")]
            public string BeginDateInclusive
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/billing_view#end_date_inclusive BillingView#end_date_inclusive}.</summary>
            [JsiiProperty(name: "endDateInclusive", typeJson: "{\"primitive\":\"string\"}")]
            public string EndDateInclusive
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
