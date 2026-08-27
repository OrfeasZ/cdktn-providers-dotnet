using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiInterface(nativeType: typeof(IDistributedDatabaseDistributedDatabaseValidateNetworkDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseValidateNetworkDetails")]
    public interface IDistributedDatabaseDistributedDatabaseValidateNetworkDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#is_surrogate DistributedDatabaseDistributedDatabase#is_surrogate}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#resource_name DistributedDatabaseDistributedDatabase#resource_name}.</summary>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#shard_group DistributedDatabaseDistributedDatabase#shard_group}.</summary>
        [JsiiProperty(name: "shardGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShardGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDistributedDatabaseDistributedDatabaseValidateNetworkDetails), fullyQualifiedName: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseValidateNetworkDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseValidateNetworkDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#is_surrogate DistributedDatabaseDistributedDatabase#is_surrogate}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isSurrogate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSurrogate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#resource_name DistributedDatabaseDistributedDatabase#resource_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/distributed_database_distributed_database#shard_group DistributedDatabaseDistributedDatabase#shard_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shardGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShardGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
