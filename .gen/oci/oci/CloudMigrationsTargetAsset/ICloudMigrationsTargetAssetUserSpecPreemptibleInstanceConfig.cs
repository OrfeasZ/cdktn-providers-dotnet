using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudMigrationsTargetAsset
{
    [JsiiInterface(nativeType: typeof(ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig), fullyQualifiedName: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig")]
    public interface ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig
    {
        /// <summary>preemption_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_migrations_target_asset#preemption_action CloudMigrationsTargetAsset#preemption_action}
        /// </remarks>
        [JsiiProperty(name: "preemptionAction", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfigPreemptionAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfigPreemptionAction? PreemptionAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig), fullyQualifiedName: "oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>preemption_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/cloud_migrations_target_asset#preemption_action CloudMigrationsTargetAsset#preemption_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preemptionAction", typeJson: "{\"fqn\":\"oci.cloudMigrationsTargetAsset.CloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfigPreemptionAction\"}", isOptional: true)]
            public oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfigPreemptionAction? PreemptionAction
            {
                get => GetInstanceProperty<oci.CloudMigrationsTargetAsset.ICloudMigrationsTargetAssetUserSpecPreemptibleInstanceConfigPreemptionAction?>();
            }
        }
    }
}
