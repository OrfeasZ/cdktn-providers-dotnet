using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousExadataInfrastructureMaintenanceWindowDetailsDaysOfWeek), fullyQualifiedName: "oci.databaseAutonomousExadataInfrastructure.DatabaseAutonomousExadataInfrastructureMaintenanceWindowDetailsDaysOfWeek")]
    public interface IDatabaseAutonomousExadataInfrastructureMaintenanceWindowDetailsDaysOfWeek
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_exadata_infrastructure#name DatabaseAutonomousExadataInfrastructure#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousExadataInfrastructureMaintenanceWindowDetailsDaysOfWeek), fullyQualifiedName: "oci.databaseAutonomousExadataInfrastructure.DatabaseAutonomousExadataInfrastructureMaintenanceWindowDetailsDaysOfWeek")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousExadataInfrastructure.IDatabaseAutonomousExadataInfrastructureMaintenanceWindowDetailsDaysOfWeek
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_exadata_infrastructure#name DatabaseAutonomousExadataInfrastructure#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
