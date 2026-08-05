using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.workspacesPool.WorkspacesPoolCapacity")]
    public class WorkspacesPoolCapacity : aws.WorkspacesPool.IWorkspacesPoolCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/workspaces_pool#desired_user_sessions WorkspacesPool#desired_user_sessions}.</summary>
        [JsiiProperty(name: "desiredUserSessions", typeJson: "{\"primitive\":\"number\"}")]
        public double DesiredUserSessions
        {
            get;
            set;
        }
    }
}
