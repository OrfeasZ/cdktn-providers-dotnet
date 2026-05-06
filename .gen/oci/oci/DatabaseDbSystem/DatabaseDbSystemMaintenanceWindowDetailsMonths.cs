using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbSystem
{
    [JsiiByValue(fqn: "oci.databaseDbSystem.DatabaseDbSystemMaintenanceWindowDetailsMonths")]
    public class DatabaseDbSystemMaintenanceWindowDetailsMonths : oci.DatabaseDbSystem.IDatabaseDbSystemMaintenanceWindowDetailsMonths
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_db_system#name DatabaseDbSystem#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
