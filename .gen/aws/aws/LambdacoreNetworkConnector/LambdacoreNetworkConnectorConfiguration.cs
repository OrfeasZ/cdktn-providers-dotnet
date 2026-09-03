using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdacoreNetworkConnector
{
    [JsiiByValue(fqn: "aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfiguration")]
    public class LambdacoreNetworkConnectorConfiguration : aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfiguration
    {
        private object? _vpcEgressConfiguration;

        /// <summary>vpc_egress_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdacore_network_connector#vpc_egress_configuration LambdacoreNetworkConnector#vpc_egress_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfigurationVpcEgressConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcEgressConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfigurationVpcEgressConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? VpcEgressConfiguration
        {
            get => _vpcEgressConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfigurationVpcEgressConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfigurationVpcEgressConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _vpcEgressConfiguration = value;
            }
        }
    }
}
