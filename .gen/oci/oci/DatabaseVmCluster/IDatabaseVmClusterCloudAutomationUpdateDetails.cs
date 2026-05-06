using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseVmClusterCloudAutomationUpdateDetails), fullyQualifiedName: "oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetails")]
    public interface IDatabaseVmClusterCloudAutomationUpdateDetails
    {
        /// <summary>apply_update_time_preference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster#apply_update_time_preference DatabaseVmCluster#apply_update_time_preference}
        /// </remarks>
        [JsiiProperty(name: "applyUpdateTimePreference", typeJson: "{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference? ApplyUpdateTimePreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>freeze_period block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster#freeze_period DatabaseVmCluster#freeze_period}
        /// </remarks>
        [JsiiProperty(name: "freezePeriod", typeJson: "{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod? FreezePeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster#is_early_adoption_enabled DatabaseVmCluster#is_early_adoption_enabled}.</summary>
        [JsiiProperty(name: "isEarlyAdoptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEarlyAdoptionEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster#is_freeze_period_enabled DatabaseVmCluster#is_freeze_period_enabled}.</summary>
        [JsiiProperty(name: "isFreezePeriodEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsFreezePeriodEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseVmClusterCloudAutomationUpdateDetails), fullyQualifiedName: "oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>apply_update_time_preference block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster#apply_update_time_preference DatabaseVmCluster#apply_update_time_preference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applyUpdateTimePreference", typeJson: "{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference\"}", isOptional: true)]
            public oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference? ApplyUpdateTimePreference
            {
                get => GetInstanceProperty<oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference?>();
            }

            /// <summary>freeze_period block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster#freeze_period DatabaseVmCluster#freeze_period}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "freezePeriod", typeJson: "{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod\"}", isOptional: true)]
            public oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod? FreezePeriod
            {
                get => GetInstanceProperty<oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster#is_early_adoption_enabled DatabaseVmCluster#is_early_adoption_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEarlyAdoptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEarlyAdoptionEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_vm_cluster#is_freeze_period_enabled DatabaseVmCluster#is_freeze_period_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isFreezePeriodEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsFreezePeriodEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
