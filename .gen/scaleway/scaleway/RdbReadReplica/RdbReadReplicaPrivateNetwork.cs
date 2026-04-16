using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RdbReadReplica
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.rdbReadReplica.RdbReadReplicaPrivateNetwork")]
    public class RdbReadReplicaPrivateNetwork : scaleway.RdbReadReplica.IRdbReadReplicaPrivateNetwork
    {
        /// <summary>UUID of the private network to be connected to the read replica (UUID format).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#private_network_id RdbReadReplica#private_network_id}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateNetworkId
        {
            get;
            set;
        }

        private object? _enableIpam;

        /// <summary>Whether or not the private network endpoint should be configured with IPAM.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#enable_ipam RdbReadReplica#enable_ipam}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableIpam", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableIpam
        {
            get => _enableIpam;
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
                _enableIpam = value;
            }
        }

        /// <summary>The IP network address within the private subnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#service_ip RdbReadReplica#service_ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceIp
        {
            get;
            set;
        }
    }
}
