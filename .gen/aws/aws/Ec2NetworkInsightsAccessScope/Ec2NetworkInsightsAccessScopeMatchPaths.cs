using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsAccessScope
{
    [JsiiByValue(fqn: "aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeMatchPaths")]
    public class Ec2NetworkInsightsAccessScopeMatchPaths : aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeMatchPaths
    {
        private object? _destination;

        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#destination Ec2NetworkInsightsAccessScope#destination}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeMatchPathsDestination\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Destination
        {
            get => _destination;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeMatchPathsDestination[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeMatchPathsDestination).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _destination = value;
            }
        }

        private object? _source;

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/ec2_network_insights_access_scope#source Ec2NetworkInsightsAccessScope#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2NetworkInsightsAccessScope.Ec2NetworkInsightsAccessScopeMatchPathsSource\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Source
        {
            get => _source;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeMatchPathsSource[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.Ec2NetworkInsightsAccessScope.IEc2NetworkInsightsAccessScopeMatchPathsSource).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _source = value;
            }
        }
    }
}
