using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepositorySetting
{
    [JsiiInterface(nativeType: typeof(IDevopsRepositorySettingApprovalRules), fullyQualifiedName: "oci.devopsRepositorySetting.DevopsRepositorySettingApprovalRules")]
    public interface IDevopsRepositorySettingApprovalRules
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#items DevopsRepositorySetting#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingApprovalRulesItems\"},\"kind\":\"array\"}}]}}")]
        object Items
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsRepositorySettingApprovalRules), fullyQualifiedName: "oci.devopsRepositorySetting.DevopsRepositorySettingApprovalRules")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsRepositorySetting.IDevopsRepositorySettingApprovalRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#items DevopsRepositorySetting#items}
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsRepositorySetting.DevopsRepositorySettingApprovalRulesItems\"},\"kind\":\"array\"}}]}}")]
            public object Items
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
