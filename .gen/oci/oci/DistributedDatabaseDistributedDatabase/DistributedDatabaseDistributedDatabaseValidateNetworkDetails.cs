using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedDatabase
{
    [JsiiByValue(fqn: "oci.distributedDatabaseDistributedDatabase.DistributedDatabaseDistributedDatabaseValidateNetworkDetails")]
    public class DistributedDatabaseDistributedDatabaseValidateNetworkDetails : oci.DistributedDatabaseDistributedDatabase.IDistributedDatabaseDistributedDatabaseValidateNetworkDetails
    {
        private object? _isSurrogate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/distributed_database_distributed_database#is_surrogate DistributedDatabaseDistributedDatabase#is_surrogate}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isSurrogate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSurrogate
        {
            get => _isSurrogate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isSurrogate = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/distributed_database_distributed_database#resource_name DistributedDatabaseDistributedDatabase#resource_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.25.0/docs/resources/distributed_database_distributed_database#shard_group DistributedDatabaseDistributedDatabase#shard_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shardGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ShardGroup
        {
            get;
            set;
        }
    }
}
