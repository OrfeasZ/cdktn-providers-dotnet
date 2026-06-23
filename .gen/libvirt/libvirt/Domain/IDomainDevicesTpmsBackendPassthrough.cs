using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesTpmsBackendPassthrough), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendPassthrough")]
    public interface IDomainDevicesTpmsBackendPassthrough
    {
        /// <summary>Sets the host character or TPM device used by the passthrough TPM backend;</summary>
        /// <remarks>
        /// the device element groups attributes describing the host TPM node.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#device Domain#device}
        /// </remarks>
        [JsiiProperty(name: "device", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendPassthroughDevice\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesTpmsBackendPassthroughDevice? Device
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesTpmsBackendPassthrough), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendPassthrough")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesTpmsBackendPassthrough
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the host character or TPM device used by the passthrough TPM backend;</summary>
            /// <remarks>
            /// the device element groups attributes describing the host TPM node.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#device Domain#device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "device", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendPassthroughDevice\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesTpmsBackendPassthroughDevice? Device
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesTpmsBackendPassthroughDevice?>();
            }
        }
    }
}
