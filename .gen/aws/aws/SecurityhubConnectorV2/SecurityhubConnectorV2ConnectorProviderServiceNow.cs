using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubConnectorV2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderServiceNow")]
    public class SecurityhubConnectorV2ConnectorProviderServiceNow : aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderServiceNow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_connector_v2#instance_name SecurityhubConnectorV2#instance_name}.</summary>
        [JsiiProperty(name: "instanceName", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_connector_v2#secret_arn SecurityhubConnectorV2#secret_arn}.</summary>
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretArn
        {
            get;
            set;
        }
    }
}
