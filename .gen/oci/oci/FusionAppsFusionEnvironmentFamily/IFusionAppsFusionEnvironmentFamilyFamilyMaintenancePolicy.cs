using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironmentFamily
{
    [JsiiInterface(nativeType: typeof(IFusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicy), fullyQualifiedName: "oci.fusionAppsFusionEnvironmentFamily.FusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicy")]
    public interface IFusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_family#concurrent_maintenance FusionAppsFusionEnvironmentFamily#concurrent_maintenance}.</summary>
        [JsiiProperty(name: "concurrentMaintenance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConcurrentMaintenance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_family#is_monthly_patching_enabled FusionAppsFusionEnvironmentFamily#is_monthly_patching_enabled}.</summary>
        [JsiiProperty(name: "isMonthlyPatchingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsMonthlyPatchingEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_family#quarterly_upgrade_begin_times FusionAppsFusionEnvironmentFamily#quarterly_upgrade_begin_times}.</summary>
        [JsiiProperty(name: "quarterlyUpgradeBeginTimes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QuarterlyUpgradeBeginTimes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicy), fullyQualifiedName: "oci.fusionAppsFusionEnvironmentFamily.FusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicy")]
        internal sealed class _Proxy : DeputyBase, oci.FusionAppsFusionEnvironmentFamily.IFusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_family#concurrent_maintenance FusionAppsFusionEnvironmentFamily#concurrent_maintenance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "concurrentMaintenance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConcurrentMaintenance
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_family#is_monthly_patching_enabled FusionAppsFusionEnvironmentFamily#is_monthly_patching_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isMonthlyPatchingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsMonthlyPatchingEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment_family#quarterly_upgrade_begin_times FusionAppsFusionEnvironmentFamily#quarterly_upgrade_begin_times}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "quarterlyUpgradeBeginTimes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QuarterlyUpgradeBeginTimes
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
