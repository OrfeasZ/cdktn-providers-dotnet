using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RdbInstance
{
    [JsiiInterface(nativeType: typeof(IRdbInstancePrivateNetwork), fullyQualifiedName: "scaleway.rdbInstance.RdbInstancePrivateNetwork")]
    public interface IRdbInstancePrivateNetwork
    {
        /// <summary>The private network ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#pn_id RdbInstance#pn_id}
        /// </remarks>
        [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
        string PnId
        {
            get;
        }

        /// <summary>Whether or not the private network endpoint should be configured with IPAM.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#enable_ipam RdbInstance#enable_ipam}
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

        /// <summary>The IP with the given mask within the private subnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#ip_net RdbInstance#ip_net}
        /// </remarks>
        [JsiiProperty(name: "ipNet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpNet
        {
            get
            {
                return null;
            }
        }

        /// <summary>The port of your private service.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#port RdbInstance#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>The zone you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#zone RdbInstance#zone}
        /// </remarks>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdbInstancePrivateNetwork), fullyQualifiedName: "scaleway.rdbInstance.RdbInstancePrivateNetwork")]
        internal sealed class _Proxy : DeputyBase, scaleway.RdbInstance.IRdbInstancePrivateNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The private network ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#pn_id RdbInstance#pn_id}
            /// </remarks>
            [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
            public string PnId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether or not the private network endpoint should be configured with IPAM.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#enable_ipam RdbInstance#enable_ipam}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableIpam", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableIpam
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The IP with the given mask within the private subnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#ip_net RdbInstance#ip_net}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipNet", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpNet
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The port of your private service.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#port RdbInstance#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The zone you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#zone RdbInstance#zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
