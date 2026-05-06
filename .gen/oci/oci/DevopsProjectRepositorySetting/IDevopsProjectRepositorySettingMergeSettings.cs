using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsProjectRepositorySetting
{
    [JsiiInterface(nativeType: typeof(IDevopsProjectRepositorySettingMergeSettings), fullyQualifiedName: "oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingMergeSettings")]
    public interface IDevopsProjectRepositorySettingMergeSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#allowed_merge_strategies DevopsProjectRepositorySetting#allowed_merge_strategies}.</summary>
        [JsiiProperty(name: "allowedMergeStrategies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedMergeStrategies
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#default_merge_strategy DevopsProjectRepositorySetting#default_merge_strategy}.</summary>
        [JsiiProperty(name: "defaultMergeStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultMergeStrategy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsProjectRepositorySettingMergeSettings), fullyQualifiedName: "oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingMergeSettings")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingMergeSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#allowed_merge_strategies DevopsProjectRepositorySetting#allowed_merge_strategies}.</summary>
            [JsiiProperty(name: "allowedMergeStrategies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedMergeStrategies
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#default_merge_strategy DevopsProjectRepositorySetting#default_merge_strategy}.</summary>
            [JsiiProperty(name: "defaultMergeStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultMergeStrategy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
