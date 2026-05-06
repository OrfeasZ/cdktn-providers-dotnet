using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsProjectRepositorySetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsProjectRepositorySetting.DevopsProjectRepositorySettingMergeSettings")]
    public class DevopsProjectRepositorySettingMergeSettings : oci.DevopsProjectRepositorySetting.IDevopsProjectRepositorySettingMergeSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#allowed_merge_strategies DevopsProjectRepositorySetting#allowed_merge_strategies}.</summary>
        [JsiiProperty(name: "allowedMergeStrategies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AllowedMergeStrategies
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_project_repository_setting#default_merge_strategy DevopsProjectRepositorySetting#default_merge_strategy}.</summary>
        [JsiiProperty(name: "defaultMergeStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultMergeStrategy
        {
            get;
            set;
        }
    }
}
