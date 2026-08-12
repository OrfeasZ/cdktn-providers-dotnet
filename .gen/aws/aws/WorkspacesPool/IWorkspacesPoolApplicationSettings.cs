using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesPool
{
    [JsiiInterface(nativeType: typeof(IWorkspacesPoolApplicationSettings), fullyQualifiedName: "aws.workspacesPool.WorkspacesPoolApplicationSettings")]
    public interface IWorkspacesPoolApplicationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/workspaces_pool#settings_group WorkspacesPool#settings_group}.</summary>
        [JsiiProperty(name: "settingsGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SettingsGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/workspaces_pool#status WorkspacesPool#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspacesPoolApplicationSettings), fullyQualifiedName: "aws.workspacesPool.WorkspacesPoolApplicationSettings")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspacesPool.IWorkspacesPoolApplicationSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/workspaces_pool#settings_group WorkspacesPool#settings_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "settingsGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SettingsGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/workspaces_pool#status WorkspacesPool#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
