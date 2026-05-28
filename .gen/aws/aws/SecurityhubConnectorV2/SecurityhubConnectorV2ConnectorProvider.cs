using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubConnectorV2
{
    [JsiiByValue(fqn: "aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProvider")]
    public class SecurityhubConnectorV2ConnectorProvider : aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProvider
    {
        private object? _jiraCloud;

        /// <summary>jira_cloud block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_connector_v2#jira_cloud SecurityhubConnectorV2#jira_cloud}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jiraCloud", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderJiraCloud\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? JiraCloud
        {
            get => _jiraCloud;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderJiraCloud[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderJiraCloud).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _jiraCloud = value;
            }
        }

        private object? _serviceNow;

        /// <summary>service_now block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/securityhub_connector_v2#service_now SecurityhubConnectorV2#service_now}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceNow", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securityhubConnectorV2.SecurityhubConnectorV2ConnectorProviderServiceNow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ServiceNow
        {
            get => _serviceNow;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderServiceNow[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SecurityhubConnectorV2.ISecurityhubConnectorV2ConnectorProviderServiceNow).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _serviceNow = value;
            }
        }
    }
}
