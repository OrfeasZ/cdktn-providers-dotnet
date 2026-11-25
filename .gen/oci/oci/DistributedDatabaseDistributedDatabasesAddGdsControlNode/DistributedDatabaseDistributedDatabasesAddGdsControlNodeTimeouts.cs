using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasesAddGdsControlNode
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabasesAddGdsControlNode.DistributedDatabaseDistributedDatabasesAddGdsControlNodeTimeouts")]
    public class DistributedDatabaseDistributedDatabasesAddGdsControlNodeTimeouts : oci.DistributedDatabaseDistributedDatabasesAddGdsControlNode.IDistributedDatabaseDistributedDatabasesAddGdsControlNodeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_add_gds_control_node#create DistributedDatabaseDistributedDatabasesAddGdsControlNode#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_add_gds_control_node#delete DistributedDatabaseDistributedDatabasesAddGdsControlNode#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_add_gds_control_node#update DistributedDatabaseDistributedDatabasesAddGdsControlNode#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
