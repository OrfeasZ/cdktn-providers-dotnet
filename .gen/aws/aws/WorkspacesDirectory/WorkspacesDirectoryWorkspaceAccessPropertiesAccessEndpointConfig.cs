using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesDirectory
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfig")]
    public class WorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfig : aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfig
    {
        private object _accessEndpoints;

        /// <summary>access_endpoints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/workspaces_directory#access_endpoints WorkspacesDirectory#access_endpoints}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "accessEndpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints\"},\"kind\":\"array\"}}]}}")]
        public object AccessEndpoints
        {
            get => _accessEndpoints;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _accessEndpoints = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/workspaces_directory#internet_fallback_protocols WorkspacesDirectory#internet_fallback_protocols}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "internetFallbackProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? InternetFallbackProtocols
        {
            get;
            set;
        }
    }
}
