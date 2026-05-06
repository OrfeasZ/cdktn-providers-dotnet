using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironmentRefreshActivity
{
    [JsiiByValue(fqn: "oci.fusionAppsFusionEnvironmentRefreshActivity.FusionAppsFusionEnvironmentRefreshActivityTimeouts")]
    public class FusionAppsFusionEnvironmentRefreshActivityTimeouts : oci.FusionAppsFusionEnvironmentRefreshActivity.IFusionAppsFusionEnvironmentRefreshActivityTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_refresh_activity#create FusionAppsFusionEnvironmentRefreshActivity#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
