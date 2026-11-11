using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConnector
{
    [JsiiByValue(fqn: "aws.configConnector.ConfigConnectorConnectorConfiguration")]
    public class ConfigConnectorConnectorConfiguration : aws.ConfigConnector.IConfigConnectorConnectorConfiguration
    {
        private object? _azure;

        /// <summary>azure block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/config_connector#azure ConfigConnector#azure}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.ConfigConnector.IConfigConnectorConnectorConfigurationAzure" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azure", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.configConnector.ConfigConnectorConnectorConfigurationAzure\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Azure
        {
            get => _azure;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.ConfigConnector.IConfigConnectorConnectorConfigurationAzure[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ConfigConnector.IConfigConnectorConnectorConfigurationAzure).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _azure = value;
            }
        }
    }
}
