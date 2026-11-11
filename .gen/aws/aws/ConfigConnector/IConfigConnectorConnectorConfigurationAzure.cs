using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConnector
{
    [JsiiInterface(nativeType: typeof(IConfigConnectorConnectorConfigurationAzure), fullyQualifiedName: "aws.configConnector.ConfigConnectorConnectorConfigurationAzure")]
    public interface IConfigConnectorConnectorConfigurationAzure
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/config_connector#client_identifier ConfigConnector#client_identifier}.</summary>
        [JsiiProperty(name: "clientIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ClientIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/config_connector#tenant_identifier ConfigConnector#tenant_identifier}.</summary>
        [JsiiProperty(name: "tenantIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string TenantIdentifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConnectorConnectorConfigurationAzure), fullyQualifiedName: "aws.configConnector.ConfigConnectorConnectorConfigurationAzure")]
        internal sealed class _Proxy : DeputyBase, aws.ConfigConnector.IConfigConnectorConnectorConfigurationAzure
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/config_connector#client_identifier ConfigConnector#client_identifier}.</summary>
            [JsiiProperty(name: "clientIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/config_connector#tenant_identifier ConfigConnector#tenant_identifier}.</summary>
            [JsiiProperty(name: "tenantIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string TenantIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
