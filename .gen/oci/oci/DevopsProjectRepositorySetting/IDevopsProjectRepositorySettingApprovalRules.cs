using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsProjectRepositorySetting
{
    [JsiiInterface(nativeType: typeof(IDevopsProjectRepositorySettingApprovalRules), fullyQualifiedName: "oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRules")]
    public interface IDevopsProjectRepositorySettingApprovalRules
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#items DevopsProjectRepositorySetting#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRulesItems\"},\"kind\":\"array\"}}]}}")]
        object Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsProjectRepositorySettingApprovalRules), fullyQualifiedName: "oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRules")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingApprovalRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#items DevopsProjectRepositorySetting#items}
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingApprovalRulesItems\"},\"kind\":\"array\"}}]}}")]
            public object Items
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
