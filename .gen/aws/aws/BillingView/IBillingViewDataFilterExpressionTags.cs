using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BillingView
{
    [JsiiInterface(nativeType: typeof(IBillingViewDataFilterExpressionTags), fullyQualifiedName: "aws.billingView.BillingViewDataFilterExpressionTags")]
    public interface IBillingViewDataFilterExpressionTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/billing_view#key BillingView#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/billing_view#values BillingView#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingViewDataFilterExpressionTags), fullyQualifiedName: "aws.billingView.BillingViewDataFilterExpressionTags")]
        internal sealed class _Proxy : DeputyBase, aws.BillingView.IBillingViewDataFilterExpressionTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/billing_view#key BillingView#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/billing_view#values BillingView#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
