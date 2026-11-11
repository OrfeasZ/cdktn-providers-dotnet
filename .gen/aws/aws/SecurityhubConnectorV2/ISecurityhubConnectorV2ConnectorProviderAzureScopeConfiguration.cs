using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubConnectorV2
{
    [JsiiInterface(nativeType: typeof(ISecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration), fullyQualifiedName: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration")]
    public interface ISecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#scope_type SecurityhubConnectorV2#scope_type}.</summary>
        [JsiiProperty(name: "scopeType", typeJson: "{\"primitive\":\"string\"}")]
        string ScopeType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#scope_values SecurityhubConnectorV2#scope_values}.</summary>
        [JsiiProperty(name: "scopeValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ScopeValues
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration), fullyQualifiedName: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderAzureScopeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#scope_type SecurityhubConnectorV2#scope_type}.</summary>
            [JsiiProperty(name: "scopeType", typeJson: "{\"primitive\":\"string\"}")]
            public string ScopeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/securityhub_connector_v2#scope_values SecurityhubConnectorV2#scope_values}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scopeValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ScopeValues
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
