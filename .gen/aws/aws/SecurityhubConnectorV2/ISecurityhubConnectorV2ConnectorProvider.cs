using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubConnectorV2
{
    [JsiiInterface(nativeType: typeof(ISecurityhubConnectorV2ConnectorProvider), fullyQualifiedName: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProvider")]
    public interface ISecurityhubConnectorV2ConnectorProvider
    {
        /// <summary>jira_cloud block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/securityhub_connector_v2#jira_cloud SecurityhubConnectorV2#jira_cloud}
        /// </remarks>
        [JsiiProperty(name: "jiraCloud", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderJiraCloud\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JiraCloud
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_now block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/securityhub_connector_v2#service_now SecurityhubConnectorV2#service_now}
        /// </remarks>
        [JsiiProperty(name: "serviceNow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderServiceNow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ServiceNow
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubConnectorV2ConnectorProvider), fullyQualifiedName: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProvider")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>jira_cloud block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/securityhub_connector_v2#jira_cloud SecurityhubConnectorV2#jira_cloud}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jiraCloud", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderJiraCloud\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? JiraCloud
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>service_now block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/securityhub_connector_v2#service_now SecurityhubConnectorV2#service_now}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceNow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderServiceNow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ServiceNow
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
