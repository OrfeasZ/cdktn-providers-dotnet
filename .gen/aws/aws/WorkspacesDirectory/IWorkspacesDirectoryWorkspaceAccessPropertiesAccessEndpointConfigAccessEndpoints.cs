using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesDirectory
{
    [JsiiInterface(nativeType: typeof(IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints), fullyQualifiedName: "aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints")]
    public interface IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/workspaces_directory#access_endpoint_type WorkspacesDirectory#access_endpoint_type}.</summary>
        [JsiiProperty(name: "accessEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        string AccessEndpointType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/workspaces_directory#vpc_endpoint_id WorkspacesDirectory#vpc_endpoint_id}.</summary>
        [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcEndpointId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints), fullyQualifiedName: "aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/workspaces_directory#access_endpoint_type WorkspacesDirectory#access_endpoint_type}.</summary>
            [JsiiProperty(name: "accessEndpointType", typeJson: "{\"primitive\":\"string\"}")]
            public string AccessEndpointType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/workspaces_directory#vpc_endpoint_id WorkspacesDirectory#vpc_endpoint_id}.</summary>
            [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcEndpointId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
