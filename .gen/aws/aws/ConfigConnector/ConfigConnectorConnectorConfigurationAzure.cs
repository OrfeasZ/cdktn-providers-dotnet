using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.configConnector.ConfigConnectorConnectorConfigurationAzure")]
    public class ConfigConnectorConnectorConfigurationAzure : aws.ConfigConnector.IConfigConnectorConnectorConfigurationAzure
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/config_connector#client_identifier ConfigConnector#client_identifier}.</summary>
        [JsiiProperty(name: "clientIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/config_connector#tenant_identifier ConfigConnector#tenant_identifier}.</summary>
        [JsiiProperty(name: "tenantIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string TenantIdentifier
        {
            get;
            set;
        }
    }
}
