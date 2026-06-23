using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesTpmsBackendExternal), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendExternal")]
    public interface IDomainDevicesTpmsBackendExternal
    {
        /// <summary>Configures how the external TPM backend is reached, via either a D-Bus service or a character device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesTpmsBackendExternalSource? Source
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesTpmsBackendExternal), fullyQualifiedName: "libvirt.domain.DomainDevicesTpmsBackendExternal")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesTpmsBackendExternal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures how the external TPM backend is reached, via either a D-Bus service or a character device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesTpmsBackendExternalSource\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesTpmsBackendExternalSource? Source
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesTpmsBackendExternalSource?>();
            }
        }
    }
}
