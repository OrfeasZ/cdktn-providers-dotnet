using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironment
{
    [JsiiInterface(nativeType: typeof(IFusionAppsFusionEnvironmentMaintenancePolicy), fullyQualifiedName: "oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentMaintenancePolicy")]
    public interface IFusionAppsFusionEnvironmentMaintenancePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#environment_maintenance_override FusionAppsFusionEnvironment#environment_maintenance_override}.</summary>
        [JsiiProperty(name: "environmentMaintenanceOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EnvironmentMaintenanceOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#monthly_patching_override FusionAppsFusionEnvironment#monthly_patching_override}.</summary>
        [JsiiProperty(name: "monthlyPatchingOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MonthlyPatchingOverride
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFusionAppsFusionEnvironmentMaintenancePolicy), fullyQualifiedName: "oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentMaintenancePolicy")]
        internal sealed class _Proxy : DeputyBase, oci.FusionAppsFusionEnvironment.IFusionAppsFusionEnvironmentMaintenancePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#environment_maintenance_override FusionAppsFusionEnvironment#environment_maintenance_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "environmentMaintenanceOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EnvironmentMaintenanceOverride
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fusion_apps_fusion_environment#monthly_patching_override FusionAppsFusionEnvironment#monthly_patching_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "monthlyPatchingOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MonthlyPatchingOverride
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
