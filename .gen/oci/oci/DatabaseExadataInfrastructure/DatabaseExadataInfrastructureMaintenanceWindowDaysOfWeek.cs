using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructure
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureMaintenanceWindowDaysOfWeek")]
    public class DatabaseExadataInfrastructureMaintenanceWindowDaysOfWeek : oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureMaintenanceWindowDaysOfWeek
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_exadata_infrastructure#name DatabaseExadataInfrastructure#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
