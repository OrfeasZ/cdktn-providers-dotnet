using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Network
{
    [JsiiByValue(fqn: "libvirt.network.NetworkVlan")]
    public class NetworkVlan : libvirt.Network.INetworkVlan
    {
        private object? _tags;

        /// <summary>Defines one or more VLAN tag entries for this portgroup;</summary>
        /// <remarks>
        /// each tag specifies a VLAN ID, and optionally native-mode behavior, applied to guest traffic.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#tags Network#tags}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Network.INetworkVlanTags" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.network.NetworkVlanTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Tags
        {
            get => _tags;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case libvirt.Network.INetworkVlanTags[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(libvirt.Network.INetworkVlanTags).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tags = value;
            }
        }

        /// <summary>Controls whether this portgroup’s VLAN configuration operates in trunk mode, allowing multiple VLAN tags;</summary>
        /// <remarks>
        /// value is a yes/no string flag, where "yes" enables trunk mode.
        ///
        /// See: <a href="https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatnetwork.html#setting-vlan-tag-on-supported-network-types-only</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/network#trunk Network#trunk}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "trunk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Trunk
        {
            get;
            set;
        }
    }
}
