using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepositorySetting
{
    [JsiiInterface(nativeType: typeof(IDevopsRepositorySettingMergeSettings), fullyQualifiedName: "oci.devopsRepositorySetting.DevopsRepositorySettingMergeSettings")]
    public interface IDevopsRepositorySettingMergeSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#allowed_merge_strategies DevopsRepositorySetting#allowed_merge_strategies}.</summary>
        [JsiiProperty(name: "allowedMergeStrategies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AllowedMergeStrategies
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#default_merge_strategy DevopsRepositorySetting#default_merge_strategy}.</summary>
        [JsiiProperty(name: "defaultMergeStrategy", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultMergeStrategy
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevopsRepositorySettingMergeSettings), fullyQualifiedName: "oci.devopsRepositorySetting.DevopsRepositorySettingMergeSettings")]
        internal sealed class _Proxy : DeputyBase, oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#allowed_merge_strategies DevopsRepositorySetting#allowed_merge_strategies}.</summary>
            [JsiiProperty(name: "allowedMergeStrategies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AllowedMergeStrategies
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#default_merge_strategy DevopsRepositorySetting#default_merge_strategy}.</summary>
            [JsiiProperty(name: "defaultMergeStrategy", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultMergeStrategy
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
