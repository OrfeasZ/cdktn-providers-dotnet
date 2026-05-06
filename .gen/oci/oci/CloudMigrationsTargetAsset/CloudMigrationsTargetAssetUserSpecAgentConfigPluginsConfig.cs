using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsTargetAsset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecAgentConfigPluginsConfig")]
    public class CloudMigrationsTargetAssetUserSpecAgentConfigPluginsConfig : oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecAgentConfigPluginsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#desired_state CloudMigrationsTargetAsset#desired_state}.</summary>
        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}")]
        public string DesiredState
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#name CloudMigrationsTargetAsset#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
