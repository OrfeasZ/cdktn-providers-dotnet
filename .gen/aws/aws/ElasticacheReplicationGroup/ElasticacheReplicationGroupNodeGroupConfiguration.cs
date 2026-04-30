using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticacheReplicationGroup
{
    [JsiiByValue(fqn: "aws.elasticacheReplicationGroup.ElasticacheReplicationGroupNodeGroupConfiguration")]
    public class ElasticacheReplicationGroupNodeGroupConfiguration : aws.ElasticacheReplicationGroup.IElasticacheReplicationGroupNodeGroupConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/elasticache_replication_group#node_group_id ElasticacheReplicationGroup#node_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/elasticache_replication_group#primary_availability_zone ElasticacheReplicationGroup#primary_availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryAvailabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryAvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/elasticache_replication_group#primary_outpost_arn ElasticacheReplicationGroup#primary_outpost_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryOutpostArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryOutpostArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/elasticache_replication_group#replica_availability_zones ElasticacheReplicationGroup#replica_availability_zones}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicaAvailabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ReplicaAvailabilityZones
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/elasticache_replication_group#replica_count ElasticacheReplicationGroup#replica_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicaCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReplicaCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/elasticache_replication_group#replica_outpost_arns ElasticacheReplicationGroup#replica_outpost_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicaOutpostArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ReplicaOutpostArns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/elasticache_replication_group#slots ElasticacheReplicationGroup#slots}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "slots", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Slots
        {
            get;
            set;
        }
    }
}
