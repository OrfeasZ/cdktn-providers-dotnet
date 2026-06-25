using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkDnsmasqOptions")]
    public class NetworkDnsmasqOptions : libvirt.Network.INetworkDnsmasqOptions
    {
        private object? _option;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#option Network#option}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkDnsmasqOptionsOption" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "option", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkDnsmasqOptionsOption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Option
        {
            get => _option;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkDnsmasqOptionsOption[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkDnsmasqOptionsOption).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _option = value;
            }
        }
    }
}
