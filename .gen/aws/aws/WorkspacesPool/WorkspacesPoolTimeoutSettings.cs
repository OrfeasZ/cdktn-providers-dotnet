using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesPool
{
    [JsiiByValue(fqn: "aws.workspacesPool.WorkspacesPoolTimeoutSettings")]
    public class WorkspacesPoolTimeoutSettings : aws.WorkspacesPool.IWorkspacesPoolTimeoutSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/workspaces_pool#disconnect_timeout_in_seconds WorkspacesPool#disconnect_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disconnectTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DisconnectTimeoutInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/workspaces_pool#idle_disconnect_timeout_in_seconds WorkspacesPool#idle_disconnect_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idleDisconnectTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IdleDisconnectTimeoutInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/workspaces_pool#max_user_duration_in_seconds WorkspacesPool#max_user_duration_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUserDurationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUserDurationInSeconds
        {
            get;
            set;
        }
    }
}
