using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousContainerDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousContainerDatabaseMaintenanceWindowDetailsDaysOfWeek), fullyQualifiedName: "oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseMaintenanceWindowDetailsDaysOfWeek")]
    public interface IDatabaseAutonomousContainerDatabaseMaintenanceWindowDetailsDaysOfWeek
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#name DatabaseAutonomousContainerDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousContainerDatabaseMaintenanceWindowDetailsDaysOfWeek), fullyQualifiedName: "oci.databaseAutonomousContainerDatabase.DatabaseAutonomousContainerDatabaseMaintenanceWindowDetailsDaysOfWeek")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousContainerDatabase.IDatabaseAutonomousContainerDatabaseMaintenanceWindowDetailsDaysOfWeek
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_container_database#name DatabaseAutonomousContainerDatabase#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
