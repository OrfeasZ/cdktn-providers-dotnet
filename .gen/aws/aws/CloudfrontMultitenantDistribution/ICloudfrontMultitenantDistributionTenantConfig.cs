using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionTenantConfig), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfig")]
    public interface ICloudfrontMultitenantDistributionTenantConfig
    {
        /// <summary>parameter_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#parameter_definition CloudfrontMultitenantDistribution#parameter_definition}
        /// </remarks>
        [JsiiProperty(name: "parameterDefinition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfigParameterDefinition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ParameterDefinition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionTenantConfig), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionTenantConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>parameter_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#parameter_definition CloudfrontMultitenantDistribution#parameter_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameterDefinition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfigParameterDefinition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ParameterDefinition
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
