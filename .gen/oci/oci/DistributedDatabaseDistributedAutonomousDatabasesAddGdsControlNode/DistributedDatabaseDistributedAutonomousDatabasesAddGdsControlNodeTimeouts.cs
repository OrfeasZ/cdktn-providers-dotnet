using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode.DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNodeTimeouts")]
    public class DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNodeTimeouts : oci.DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode.IDistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNodeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_add_gds_control_node#create DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_add_gds_control_node#delete DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_autonomous_databases_add_gds_control_node#update DistributedDatabaseDistributedAutonomousDatabasesAddGdsControlNode#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
