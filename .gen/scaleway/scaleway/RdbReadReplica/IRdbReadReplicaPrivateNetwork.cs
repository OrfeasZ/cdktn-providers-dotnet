using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RdbReadReplica
{
    [JsiiInterface(nativeType: typeof(IRdbReadReplicaPrivateNetwork), fullyQualifiedName: "scaleway.rdbReadReplica.RdbReadReplicaPrivateNetwork")]
    public interface IRdbReadReplicaPrivateNetwork
    {
        /// <summary>UUID of the private network to be connected to the read replica (UUID format).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#private_network_id RdbReadReplica#private_network_id}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateNetworkId
        {
            get;
        }

        /// <summary>Whether or not the private network endpoint should be configured with IPAM.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#enable_ipam RdbReadReplica#enable_ipam}
        /// </remarks>
        [JsiiProperty(name: "enableIpam", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableIpam
        {
            get
            {
                return null;
            }
        }

        /// <summary>The IP network address within the private subnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#service_ip RdbReadReplica#service_ip}
        /// </remarks>
        [JsiiProperty(name: "serviceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdbReadReplicaPrivateNetwork), fullyQualifiedName: "scaleway.rdbReadReplica.RdbReadReplicaPrivateNetwork")]
        internal sealed class _Proxy : DeputyBase, scaleway.RdbReadReplica.IRdbReadReplicaPrivateNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>UUID of the private network to be connected to the read replica (UUID format).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#private_network_id RdbReadReplica#private_network_id}
            /// </remarks>
            [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether or not the private network endpoint should be configured with IPAM.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#enable_ipam RdbReadReplica#enable_ipam}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableIpam", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableIpam
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The IP network address within the private subnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_read_replica#service_ip RdbReadReplica#service_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceIp
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
