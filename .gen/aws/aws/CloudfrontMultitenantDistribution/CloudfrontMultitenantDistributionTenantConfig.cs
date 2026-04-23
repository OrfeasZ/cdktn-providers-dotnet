using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfig")]
    public class CloudfrontMultitenantDistributionTenantConfig : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionTenantConfig
    {
        private object? _parameterDefinition;

        /// <summary>parameter_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#parameter_definition CloudfrontMultitenantDistribution#parameter_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameterDefinition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionTenantConfigParameterDefinition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ParameterDefinition
        {
            get => _parameterDefinition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionTenantConfigParameterDefinition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionTenantConfigParameterDefinition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parameterDefinition = value;
            }
        }
    }
}
