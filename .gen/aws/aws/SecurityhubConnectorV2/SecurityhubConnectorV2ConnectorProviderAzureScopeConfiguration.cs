using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubConnectorV2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration")]
    public class SecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration : aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#scope_type SecurityhubConnectorV2#scope_type}.</summary>
        [JsiiProperty(name: "scopeType", typeJson: "{\"primitive\":\"string\"}")]
        public string ScopeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#scope_values SecurityhubConnectorV2#scope_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scopeValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ScopeValues
        {
            get;
            set;
        }
    }
}
