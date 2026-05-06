using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsTargetAsset
{
    [JsiiInterface(nativeType: typeof(ICloudMigrationsTargetAssetUserSpecShapeConfig), fullyQualifiedName: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecShapeConfig")]
    public interface ICloudMigrationsTargetAssetUserSpecShapeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#baseline_ocpu_utilization CloudMigrationsTargetAsset#baseline_ocpu_utilization}.</summary>
        [JsiiProperty(name: "baselineOcpuUtilization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BaselineOcpuUtilization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#memory_in_gbs CloudMigrationsTargetAsset#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#ocpus CloudMigrationsTargetAsset#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ocpus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudMigrationsTargetAssetUserSpecShapeConfig), fullyQualifiedName: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecShapeConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecShapeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#baseline_ocpu_utilization CloudMigrationsTargetAsset#baseline_ocpu_utilization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "baselineOcpuUtilization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BaselineOcpuUtilization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#memory_in_gbs CloudMigrationsTargetAsset#memory_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/cloud_migrations_target_asset#ocpus CloudMigrationsTargetAsset#ocpus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ocpus
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
