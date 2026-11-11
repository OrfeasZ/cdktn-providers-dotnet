using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConnector
{
    [JsiiInterface(nativeType: typeof(IConfigConnectorConnectorConfiguration), fullyQualifiedName: "aws.configConnector.ConfigConnectorConnectorConfiguration")]
    public interface IConfigConnectorConnectorConfiguration
    {
        /// <summary>azure block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/config_connector#azure ConfigConnector#azure}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ConfigConnector.IConfigConnectorConnectorConfigurationAzure" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "azure", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.configConnector.ConfigConnectorConnectorConfigurationAzure\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Azure
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConnectorConnectorConfiguration), fullyQualifiedName: "aws.configConnector.ConfigConnectorConnectorConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ConfigConnector.IConfigConnectorConnectorConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>azure block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/config_connector#azure ConfigConnector#azure}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ConfigConnector.IConfigConnectorConnectorConfigurationAzure" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azure", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.configConnector.ConfigConnectorConnectorConfigurationAzure\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Azure
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
