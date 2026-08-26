using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdacoreNetworkConnector
{
    [JsiiInterface(nativeType: typeof(ILambdacoreNetworkConnectorConfiguration), fullyQualifiedName: "aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfiguration")]
    public interface ILambdacoreNetworkConnectorConfiguration
    {
        /// <summary>vpc_egress_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/lambdacore_network_connector#vpc_egress_configuration LambdacoreNetworkConnector#vpc_egress_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfigurationVpcEgressConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "vpcEgressConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfigurationVpcEgressConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VpcEgressConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdacoreNetworkConnectorConfiguration), fullyQualifiedName: "aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>vpc_egress_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/lambdacore_network_connector#vpc_egress_configuration LambdacoreNetworkConnector#vpc_egress_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.LambdacoreNetworkConnector.ILambdacoreNetworkConnectorConfigurationVpcEgressConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcEgressConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdacoreNetworkConnector.LambdacoreNetworkConnectorConfigurationVpcEgressConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? VpcEgressConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
