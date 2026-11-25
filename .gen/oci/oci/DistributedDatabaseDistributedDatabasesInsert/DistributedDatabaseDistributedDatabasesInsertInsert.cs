using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasesInsert
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabasesInsert.DistributedDatabaseDistributedDatabasesInsertInsert")]
    public class DistributedDatabaseDistributedDatabasesInsertInsert : oci.DistributedDatabaseDistributedDatabasesInsert.IDistributedDatabaseDistributedDatabasesInsertInsert
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert#selection DistributedDatabaseDistributedDatabasesInsert#selection}.</summary>
        [JsiiProperty(name: "selection", typeJson: "{\"primitive\":\"string\"}")]
        public string Selection
        {
            get;
            set;
        }

        /// <summary>Sensitive JSON document matching the selected topology's create payload.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_insert#value DistributedDatabaseDistributedDatabasesInsert#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
