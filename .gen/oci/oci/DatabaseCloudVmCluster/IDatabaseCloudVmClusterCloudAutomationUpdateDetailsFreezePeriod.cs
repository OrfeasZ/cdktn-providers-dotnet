using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudVmCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod), fullyQualifiedName: "oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod")]
    public interface IDatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#freeze_period_end_time DatabaseCloudVmCluster#freeze_period_end_time}.</summary>
        [JsiiProperty(name: "freezePeriodEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FreezePeriodEndTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#freeze_period_start_time DatabaseCloudVmCluster#freeze_period_start_time}.</summary>
        [JsiiProperty(name: "freezePeriodStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FreezePeriodStartTime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod), fullyQualifiedName: "oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#freeze_period_end_time DatabaseCloudVmCluster#freeze_period_end_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freezePeriodEndTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FreezePeriodEndTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_vm_cluster#freeze_period_start_time DatabaseCloudVmCluster#freeze_period_start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freezePeriodStartTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FreezePeriodStartTime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
