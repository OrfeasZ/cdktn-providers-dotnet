using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseVcnNsgIds")]
    public class DistributedDatabaseDistributedAutonomousDatabaseVcnNsgIds : oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseVcnNsgIds
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#nsg_ids DistributedDatabaseDistributedAutonomousDatabase#nsg_ids}.</summary>
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] NsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_database#vcn_id DistributedDatabaseDistributedAutonomousDatabase#vcn_id}.</summary>
        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public string VcnId
        {
            get;
            set;
        }
    }
}
