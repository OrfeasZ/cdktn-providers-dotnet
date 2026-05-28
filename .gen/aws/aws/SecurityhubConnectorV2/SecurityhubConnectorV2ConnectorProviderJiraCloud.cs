using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubConnectorV2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderJiraCloud")]
    public class SecurityhubConnectorV2ConnectorProviderJiraCloud : aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderJiraCloud
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_connector_v2#project_key SecurityhubConnectorV2#project_key}.</summary>
        [JsiiProperty(name: "projectKey", typeJson: "{\"primitive\":\"string\"}")]
        public string ProjectKey
        {
            get;
            set;
        }
    }
}
