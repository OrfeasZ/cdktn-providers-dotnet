using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesDirectory
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.workspacesDirectory.WorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints")]
    public class WorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints : aws.WorkspacesDirectory.IWorkspacesDirectoryWorkspaceAccessPropertiesAccessEndpointConfigAccessEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/workspaces_directory#access_endpoint_type WorkspacesDirectory#access_endpoint_type}.</summary>
        [JsiiProperty(name: "accessEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        public string AccessEndpointType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/workspaces_directory#vpc_endpoint_id WorkspacesDirectory#vpc_endpoint_id}.</summary>
        [JsiiProperty(name: "vpcEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcEndpointId
        {
            get;
            set;
        }
    }
}
