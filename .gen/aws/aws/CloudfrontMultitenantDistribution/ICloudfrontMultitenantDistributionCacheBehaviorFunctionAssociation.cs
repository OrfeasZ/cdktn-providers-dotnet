using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation")]
    public interface ICloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#event_type CloudfrontMultitenantDistribution#event_type}.</summary>
        [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}")]
        string EventType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#function_arn CloudfrontMultitenantDistribution#function_arn}.</summary>
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCacheBehaviorFunctionAssociation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#event_type CloudfrontMultitenantDistribution#event_type}.</summary>
            [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}")]
            public string EventType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#function_arn CloudfrontMultitenantDistribution#function_arn}.</summary>
            [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
