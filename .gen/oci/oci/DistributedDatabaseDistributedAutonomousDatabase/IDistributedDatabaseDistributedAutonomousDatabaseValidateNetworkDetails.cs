using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails")]
    public interface IDistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#is_surrogate DistributedDatabaseDistributedAutonomousDatabase#is_surrogate}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isSurrogate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSurrogate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#resource_name DistributedDatabaseDistributedAutonomousDatabase#resource_name}.</summary>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#shard_group DistributedDatabaseDistributedAutonomousDatabase#shard_group}.</summary>
        [JsiiProperty(name: "shardGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShardGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabase.DistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedAutonomousDatabase.IDistributedDatabaseDistributedAutonomousDatabaseValidateNetworkDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#is_surrogate DistributedDatabaseDistributedAutonomousDatabase#is_surrogate}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isSurrogate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSurrogate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#resource_name DistributedDatabaseDistributedAutonomousDatabase#resource_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_autonomous_database#shard_group DistributedDatabaseDistributedAutonomousDatabase#shard_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shardGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShardGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
