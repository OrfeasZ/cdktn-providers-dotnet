using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiInterface(nativeType: typeof(INetworkDnsmasqOptions), fullyQualifiedName: "libvirt.network.NetworkDnsmasqOptions")]
    public interface INetworkDnsmasqOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#option Network#option}.</summary>
        [JsiiProperty(name: "option", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsmasqOptionsOption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Option
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkDnsmasqOptions), fullyQualifiedName: "libvirt.network.NetworkDnsmasqOptions")]
        internal sealed class _Proxy : DeputyBase, libvirt.Network.INetworkDnsmasqOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#option Network#option}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "option", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsmasqOptionsOption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Option
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
