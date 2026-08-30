using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesVlan), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVlan")]
    public interface IDomainDevicesInterfacesVlan
    {
        /// <summary>Defines a single VLAN tag entry for this interface;</summary>
        /// <remarks>
        /// multiple entries can be specified to tag the interface with several VLAN IDs when trunking is enabled.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatdomain.html#setting-vlan-tag-on-supported-network-types-only</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tags Domain#tags}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesVlanTags" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVlanTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Controls whether the interface operates in VLAN trunk mode (when set, multiple tag entries are allowed and all are applied);</summary>
        /// <remarks>
        /// this is a presence/yes-no style flag whose valid value is typically "yes" when trunking is desired.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatdomain.html#setting-vlan-tag-on-supported-network-types-only</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#trunk Domain#trunk}
        /// </remarks>
        [JsiiProperty(name: "trunk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Trunk
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesVlan), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVlan")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesVlan
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines a single VLAN tag entry for this interface;</summary>
            /// <remarks>
            /// multiple entries can be specified to tag the interface with several VLAN IDs when trunking is enabled.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatdomain.html#setting-vlan-tag-on-supported-network-types-only</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#tags Domain#tags}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainDevicesInterfacesVlanTags" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainDevicesInterfacesVlanTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Controls whether the interface operates in VLAN trunk mode (when set, multiple tag entries are allowed and all are applied);</summary>
            /// <remarks>
            /// this is a presence/yes-no style flag whose valid value is typically "yes" when trunking is desired.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#setting-vlan-tag-on-supported-network-types-only">https://libvirt.org/formatdomain.html#setting-vlan-tag-on-supported-network-types-only</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#trunk Domain#trunk}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trunk", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Trunk
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
