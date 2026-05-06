using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IDatabaseCloudExadataInfrastructureMaintenanceWindowDaysOfWeek), fullyQualifiedName: "oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureMaintenanceWindowDaysOfWeek")]
    public interface IDatabaseCloudExadataInfrastructureMaintenanceWindowDaysOfWeek
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#name DatabaseCloudExadataInfrastructure#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseCloudExadataInfrastructureMaintenanceWindowDaysOfWeek), fullyQualifiedName: "oci.databaseCloudExadataInfrastructure.DatabaseCloudExadataInfrastructureMaintenanceWindowDaysOfWeek")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseCloudExadataInfrastructure.IDatabaseCloudExadataInfrastructureMaintenanceWindowDaysOfWeek
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_cloud_exadata_infrastructure#name DatabaseCloudExadataInfrastructure#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
