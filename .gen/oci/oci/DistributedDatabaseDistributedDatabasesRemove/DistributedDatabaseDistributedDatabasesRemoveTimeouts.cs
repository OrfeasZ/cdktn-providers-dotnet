using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabasesRemove
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabasesRemove.DistributedDatabaseDistributedDatabasesRemoveTimeouts")]
    public class DistributedDatabaseDistributedDatabasesRemoveTimeouts : oci.DistributedDatabaseDistributedDatabasesRemove.IDistributedDatabaseDistributedDatabasesRemoveTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_remove#create DistributedDatabaseDistributedDatabasesRemove#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_remove#delete DistributedDatabaseDistributedDatabasesRemove#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_remove#read DistributedDatabaseDistributedDatabasesRemove#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.15.0/docs/resources/distributed_database_distributed_databases_remove#update DistributedDatabaseDistributedDatabasesRemove#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
