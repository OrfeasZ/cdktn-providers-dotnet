using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsRepositorySetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.devopsRepositorySetting.DevopsRepositorySettingMergeChecks")]
    public class DevopsRepositorySettingMergeChecks : oci.DevopsRepositorySetting.IDevopsRepositorySettingMergeChecks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/devops_repository_setting#last_build_succeeded DevopsRepositorySetting#last_build_succeeded}.</summary>
        [JsiiProperty(name: "lastBuildSucceeded", typeJson: "{\"primitive\":\"string\"}")]
        public string LastBuildSucceeded
        {
            get;
            set;
        }
    }
}
