using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IDatabaseExadataInfrastructureMaintenanceWindowMonths), fullyQualifiedName: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureMaintenanceWindowMonths")]
    public interface IDatabaseExadataInfrastructureMaintenanceWindowMonths
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#name DatabaseExadataInfrastructure#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseExadataInfrastructureMaintenanceWindowMonths), fullyQualifiedName: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureMaintenanceWindowMonths")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureMaintenanceWindowMonths
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#name DatabaseExadataInfrastructure#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
