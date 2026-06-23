using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh")]
    public interface IDomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh
    {
        /// <summary>Sets the 802.1Qbh VN-Tag profile identifier associated with this virtual port; the value is user-provided and must match the upstream fabric configuration.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#profile_id Domain#profile_id}
        /// </remarks>
        [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProfileId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesVirtualPortParamsVnTag8011Qbh
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the 802.1Qbh VN-Tag profile identifier associated with this virtual port; the value is user-provided and must match the upstream fabric configuration.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#virtual-network">https://libvirt.org/formatdomain.html#virtual-network</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#profile_id Domain#profile_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProfileId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
