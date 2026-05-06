using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousVmCluster
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek), fullyQualifiedName: "oci.databaseAutonomousVmCluster.DatabaseAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek")]
    public interface IDatabaseAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster#name DatabaseAutonomousVmCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek), fullyQualifiedName: "oci.databaseAutonomousVmCluster.DatabaseAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousVmCluster.IDatabaseAutonomousVmClusterMaintenanceWindowDetailsDaysOfWeek
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_vm_cluster#name DatabaseAutonomousVmCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
