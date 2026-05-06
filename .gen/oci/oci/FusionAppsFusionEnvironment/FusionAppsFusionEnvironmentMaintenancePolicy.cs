using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironment
{
    [JsiiByValue(fqn: "oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentMaintenancePolicy")]
    public class FusionAppsFusionEnvironmentMaintenancePolicy : oci.FusionAppsFusionEnvironment.IFusionAppsFusionEnvironmentMaintenancePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#environment_maintenance_override FusionAppsFusionEnvironment#environment_maintenance_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "environmentMaintenanceOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EnvironmentMaintenanceOverride
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#monthly_patching_override FusionAppsFusionEnvironment#monthly_patching_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monthlyPatchingOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MonthlyPatchingOverride
        {
            get;
            set;
        }
    }
}
