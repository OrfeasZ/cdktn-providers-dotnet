using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainResourceFibreChannel), fullyQualifiedName: "libvirt.domain.DomainResourceFibreChannel")]
    public interface IDomainResourceFibreChannel
    {
        /// <summary>Sets the Fibre Channel VMID (appid) used by SAN/NVMe-FC infrastructure for per-VM QoS, access control, and telemetry;</summary>
        /// <remarks>
        /// the value is user-provided and must match the storage fabric’s expected VMID format.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#fibre-channel-vmid">https://libvirt.org/formatdomain.html#fibre-channel-vmid</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#app_id Domain#app_id}
        /// </remarks>
        [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
        string AppId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainResourceFibreChannel), fullyQualifiedName: "libvirt.domain.DomainResourceFibreChannel")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainResourceFibreChannel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the Fibre Channel VMID (appid) used by SAN/NVMe-FC infrastructure for per-VM QoS, access control, and telemetry;</summary>
            /// <remarks>
            /// the value is user-provided and must match the storage fabric’s expected VMID format.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#fibre-channel-vmid">https://libvirt.org/formatdomain.html#fibre-channel-vmid</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#app_id Domain#app_id}
            /// </remarks>
            [JsiiProperty(name: "appId", typeJson: "{\"primitive\":\"string\"}")]
            public string AppId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
