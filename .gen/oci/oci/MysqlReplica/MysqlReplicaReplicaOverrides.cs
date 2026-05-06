using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlReplica
{
    [JsiiByValue(fqn: "oci.mysqlReplica.MysqlReplicaReplicaOverrides")]
    public class MysqlReplicaReplicaOverrides : oci.MysqlReplica.IMysqlReplicaReplicaOverrides
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_replica#configuration_id MysqlReplica#configuration_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configurationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigurationId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_replica#mysql_version MysqlReplica#mysql_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MysqlVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_replica#nsg_ids MysqlReplica#nsg_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NsgIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_replica#security_attributes MysqlReplica#security_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? SecurityAttributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/mysql_replica#shape_name MysqlReplica#shape_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShapeName
        {
            get;
            set;
        }
    }
}
