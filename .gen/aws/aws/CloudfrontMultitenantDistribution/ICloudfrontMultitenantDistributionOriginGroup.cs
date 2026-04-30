using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionOriginGroup), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroup")]
    public interface ICloudfrontMultitenantDistributionOriginGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#id CloudfrontMultitenantDistribution#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>failover_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#failover_criteria CloudfrontMultitenantDistribution#failover_criteria}
        /// </remarks>
        [JsiiProperty(name: "failoverCriteria", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroupFailoverCriteria\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailoverCriteria
        {
            get
            {
                return null;
            }
        }

        /// <summary>member block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#member CloudfrontMultitenantDistribution#member}
        /// </remarks>
        [JsiiProperty(name: "member", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroupMember\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Member
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionOriginGroup), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroup")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#id CloudfrontMultitenantDistribution#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>failover_criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#failover_criteria CloudfrontMultitenantDistribution#failover_criteria}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failoverCriteria", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroupFailoverCriteria\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FailoverCriteria
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>member block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#member CloudfrontMultitenantDistribution#member}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "member", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroupMember\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Member
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
