using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesInsert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabasesInsert.DistributedDatabaseDistributedAutonomousDatabasesInsertInsert")]
    public class DistributedDatabaseDistributedAutonomousDatabasesInsertInsert : oci.DistributedDatabaseDistributedAutonomousDatabasesInsert.IDistributedDatabaseDistributedAutonomousDatabasesInsertInsert
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert#selection DistributedDatabaseDistributedAutonomousDatabasesInsert#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        public string Selection
        {
            get;
            set;
        }

        /// <summary>Sensitive JSON document matching the selected topology's create payload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_insert#value DistributedDatabaseDistributedAutonomousDatabasesInsert#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
