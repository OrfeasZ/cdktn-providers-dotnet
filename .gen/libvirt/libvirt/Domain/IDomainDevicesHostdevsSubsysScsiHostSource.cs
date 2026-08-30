using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesHostdevsSubsysScsiHostSource), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiHostSource")]
    public interface IDomainDevicesHostdevsSubsysScsiHostSource
    {
        /// <summary>Sets the transport protocol used by the SCSI host adapter source (for example, "fc" for Fibre Channel);</summary>
        /// <remarks>
        /// the value is user-provided and must be supported by the host.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#protocol Domain#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the World Wide Port Name (WWPN) of the SCSI/Fibre Channel host adapter source as a user-provided string, typically a 16‑hex‑digit identifier like "5005076801401b3f".</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#wwpn Domain#wwpn}
        /// </remarks>
        [JsiiProperty(name: "wwpn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Wwpn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesHostdevsSubsysScsiHostSource), fullyQualifiedName: "libvirt.domain.DomainDevicesHostdevsSubsysScsiHostSource")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesHostdevsSubsysScsiHostSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the transport protocol used by the SCSI host adapter source (for example, "fc" for Fibre Channel);</summary>
            /// <remarks>
            /// the value is user-provided and must be supported by the host.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#protocol Domain#protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the World Wide Port Name (WWPN) of the SCSI/Fibre Channel host adapter source as a user-provided string, typically a 16‑hex‑digit identifier like "5005076801401b3f".</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#host-device-assignment">https://libvirt.org/formatdomain.html#host-device-assignment</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#wwpn Domain#wwpn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wwpn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Wwpn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
