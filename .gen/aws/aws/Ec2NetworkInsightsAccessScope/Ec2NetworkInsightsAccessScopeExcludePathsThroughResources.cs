using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsAccessScope
{
    [JsiiByValue(fqn: "aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeExcludePathsThroughResources")]
    public class Ec2NetworkInsightsAccessScopeExcludePathsThroughResources : aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeExcludePathsThroughResources
    {
        private object? _resourceStatement;

        /// <summary>resource_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#resource_statement Ec2NetworkInsightsAccessScope#resource_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceStatement", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeExcludePathsThroughResourcesResourceStatement\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceStatement
        {
            get => _resourceStatement;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeExcludePathsThroughResourcesResourceStatement[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeExcludePathsThroughResourcesResourceStatement).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceStatement = value;
            }
        }
    }
}
