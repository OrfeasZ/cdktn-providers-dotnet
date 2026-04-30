using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinition), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinition")]
    public interface ICloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinition
    {
        /// <summary>string_schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#string_schema CloudfrontMultitenantDistribution#string_schema}
        /// </remarks>
        [JsiiProperty(name: "stringSchema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinitionStringSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringSchema
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinition), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>string_schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#string_schema CloudfrontMultitenantDistribution#string_schema}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringSchema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinitionStringSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringSchema
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
