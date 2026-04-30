using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinition")]
    public class CloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinition : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinition
    {
        private object? _stringSchema;

        /// <summary>string_schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#string_schema CloudfrontMultitenantDistribution#string_schema}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringSchema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinitionStringSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StringSchema
        {
            get => _stringSchema;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinitionStringSchema[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionTenantConfigParameterDefinitionDefinitionStringSchema).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringSchema = value;
            }
        }
    }
}
