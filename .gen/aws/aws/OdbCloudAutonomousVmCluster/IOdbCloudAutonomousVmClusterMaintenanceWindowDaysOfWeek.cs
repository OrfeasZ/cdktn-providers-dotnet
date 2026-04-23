using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbCloudAutonomousVmCluster
{
    [JsiiInterface(nativeType: typeof(IOdbCloudAutonomousVmClusterMaintenanceWindowDaysOfWeek), fullyQualifiedName: "aws.odbCloudAutonomousVmCluster.OdbCloudAutonomousVmClusterMaintenanceWindowDaysOfWeek")]
    public interface IOdbCloudAutonomousVmClusterMaintenanceWindowDaysOfWeek
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_cloud_autonomous_vm_cluster#name OdbCloudAutonomousVmCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbCloudAutonomousVmClusterMaintenanceWindowDaysOfWeek), fullyQualifiedName: "aws.odbCloudAutonomousVmCluster.OdbCloudAutonomousVmClusterMaintenanceWindowDaysOfWeek")]
        internal sealed class _Proxy : DeputyBase, aws.OdbCloudAutonomousVmCluster.IOdbCloudAutonomousVmClusterMaintenanceWindowDaysOfWeek
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_cloud_autonomous_vm_cluster#name OdbCloudAutonomousVmCluster#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
