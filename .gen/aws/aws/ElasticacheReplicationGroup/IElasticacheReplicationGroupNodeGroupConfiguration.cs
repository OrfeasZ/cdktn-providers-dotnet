using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticacheReplicationGroup
{
    [JsiiInterface(nativeType: typeof(IElasticacheReplicationGroupNodeGroupConfiguration), fullyQualifiedName: "aws.elasticacheReplicationGroup.ElasticacheReplicationGroupNodeGroupConfiguration")]
    public interface IElasticacheReplicationGroupNodeGroupConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#node_group_id ElasticacheReplicationGroup#node_group_id}.</summary>
        [JsiiProperty(name: "nodeGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#primary_availability_zone ElasticacheReplicationGroup#primary_availability_zone}.</summary>
        [JsiiProperty(name: "primaryAvailabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryAvailabilityZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#primary_outpost_arn ElasticacheReplicationGroup#primary_outpost_arn}.</summary>
        [JsiiProperty(name: "primaryOutpostArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryOutpostArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#replica_availability_zones ElasticacheReplicationGroup#replica_availability_zones}.</summary>
        [JsiiProperty(name: "replicaAvailabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ReplicaAvailabilityZones
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#replica_count ElasticacheReplicationGroup#replica_count}.</summary>
        [JsiiProperty(name: "replicaCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReplicaCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#replica_outpost_arns ElasticacheReplicationGroup#replica_outpost_arns}.</summary>
        [JsiiProperty(name: "replicaOutpostArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ReplicaOutpostArns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#slots ElasticacheReplicationGroup#slots}.</summary>
        [JsiiProperty(name: "slots", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Slots
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticacheReplicationGroupNodeGroupConfiguration), fullyQualifiedName: "aws.elasticacheReplicationGroup.ElasticacheReplicationGroupNodeGroupConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ElasticacheReplicationGroup.IElasticacheReplicationGroupNodeGroupConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#node_group_id ElasticacheReplicationGroup#node_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#primary_availability_zone ElasticacheReplicationGroup#primary_availability_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryAvailabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryAvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#primary_outpost_arn ElasticacheReplicationGroup#primary_outpost_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryOutpostArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryOutpostArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#replica_availability_zones ElasticacheReplicationGroup#replica_availability_zones}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicaAvailabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ReplicaAvailabilityZones
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#replica_count ElasticacheReplicationGroup#replica_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicaCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReplicaCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#replica_outpost_arns ElasticacheReplicationGroup#replica_outpost_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicaOutpostArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ReplicaOutpostArns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/elasticache_replication_group#slots ElasticacheReplicationGroup#slots}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "slots", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Slots
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
