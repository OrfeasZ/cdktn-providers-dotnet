using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesDirectory
{
    [JsiiInterface(nativeType: typeof(IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfig), fullyQualifiedName: "aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfig")]
    public interface IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfig
    {
        /// <summary>access_endpoints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/workspaces_directory#access_endpoints WorkspacesDirectory#access_endpoints}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "accessEndpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints\"},\"kind\":\"array\"}}]}}")]
        object AccessEndpoints
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/workspaces_directory#internet_fallback_protocols WorkspacesDirectory#internet_fallback_protocols}.</summary>
        [JsiiProperty(name: "internetFallbackProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? InternetFallbackProtocols
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfig), fullyQualifiedName: "aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfig")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access_endpoints block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/workspaces_directory#access_endpoints WorkspacesDirectory#access_endpoints}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "accessEndpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints\"},\"kind\":\"array\"}}]}}")]
            public object AccessEndpoints
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/workspaces_directory#internet_fallback_protocols WorkspacesDirectory#internet_fallback_protocols}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "internetFallbackProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? InternetFallbackProtocols
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
