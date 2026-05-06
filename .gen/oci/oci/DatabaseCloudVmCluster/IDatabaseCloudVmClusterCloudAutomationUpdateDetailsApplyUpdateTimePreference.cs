using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudVmCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference), fullyQualifiedName: "oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference")]
    public interface IDatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#apply_update_preferred_end_time DatabaseCloudVmCluster#apply_update_preferred_end_time}.</summary>
        [JsiiProperty(name: "applyUpdatePreferredEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplyUpdatePreferredEndTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#apply_update_preferred_start_time DatabaseCloudVmCluster#apply_update_preferred_start_time}.</summary>
        [JsiiProperty(name: "applyUpdatePreferredStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplyUpdatePreferredStartTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference), fullyQualifiedName: "oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#apply_update_preferred_end_time DatabaseCloudVmCluster#apply_update_preferred_end_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applyUpdatePreferredEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplyUpdatePreferredEndTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#apply_update_preferred_start_time DatabaseCloudVmCluster#apply_update_preferred_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applyUpdatePreferredStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplyUpdatePreferredStartTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
