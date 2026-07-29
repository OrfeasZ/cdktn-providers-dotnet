using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesPool
{
    [JsiiByValue(fqn: "aws.workspacesPool.WorkspacesPoolApplicationSettings")]
    public class WorkspacesPoolApplicationSettings : aws.WorkspacesPool.IWorkspacesPoolApplicationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/workspaces_pool#settings_group WorkspacesPool#settings_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "settingsGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SettingsGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/workspaces_pool#status WorkspacesPool#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
