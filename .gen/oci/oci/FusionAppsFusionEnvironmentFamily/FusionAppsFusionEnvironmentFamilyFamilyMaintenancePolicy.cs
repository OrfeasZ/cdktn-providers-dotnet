using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironmentFamily
{
    [JsiiByValue(fqn: "oci.fusionAppsFusionEnvironmentFamily.FusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicy")]
    public class FusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicy : oci.FusionAppsFusionEnvironmentFamily.IFusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_family#concurrent_maintenance FusionAppsFusionEnvironmentFamily#concurrent_maintenance}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "concurrentMaintenance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConcurrentMaintenance
        {
            get;
            set;
        }

        private object? _isMonthlyPatchingEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_family#is_monthly_patching_enabled FusionAppsFusionEnvironmentFamily#is_monthly_patching_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isMonthlyPatchingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsMonthlyPatchingEnabled
        {
            get => _isMonthlyPatchingEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isMonthlyPatchingEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_family#quarterly_upgrade_begin_times FusionAppsFusionEnvironmentFamily#quarterly_upgrade_begin_times}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "quarterlyUpgradeBeginTimes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QuarterlyUpgradeBeginTimes
        {
            get;
            set;
        }
    }
}
