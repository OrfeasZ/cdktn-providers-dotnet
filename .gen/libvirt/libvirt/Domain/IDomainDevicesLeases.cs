using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesLeases), fullyQualifiedName: "libvirt.domain.DomainDevicesLeases")]
    public interface IDomainDevicesLeases
    {
        /// <summary>Reports the key string that uniquely identifies this lease in the lock manager;</summary>
        /// <remarks>
        /// when omitted in config it is computed, but if set it must be a user-provided opaque identifier such as "vm1-disk1".
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#device-leases">https://libvirt.org/formatdomain.html#device-leases</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#key Domain#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Sets the lockspace name in which this lease key is managed;</summary>
        /// <remarks>
        /// value is a user-provided string chosen according to the lock manager configuration.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#device-leases">https://libvirt.org/formatdomain.html#device-leases</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#lockspace Domain#lockspace}
        /// </remarks>
        [JsiiProperty(name: "lockspace", typeJson: "{\"primitive\":\"string\"}")]
        string Lockspace
        {
            get;
        }

        /// <summary>Configures the target device or resource path associated with this lease (for example, a disk path or volume name);</summary>
        /// <remarks>
        /// value is user-provided.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#target Domain#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesLeasesTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesLeasesTarget? Target
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesLeases), fullyQualifiedName: "libvirt.domain.DomainDevicesLeases")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesLeases
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Reports the key string that uniquely identifies this lease in the lock manager;</summary>
            /// <remarks>
            /// when omitted in config it is computed, but if set it must be a user-provided opaque identifier such as "vm1-disk1".
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#device-leases">https://libvirt.org/formatdomain.html#device-leases</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#key Domain#key}
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the lockspace name in which this lease key is managed;</summary>
            /// <remarks>
            /// value is a user-provided string chosen according to the lock manager configuration.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#device-leases">https://libvirt.org/formatdomain.html#device-leases</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#lockspace Domain#lockspace}
            /// </remarks>
            [JsiiProperty(name: "lockspace", typeJson: "{\"primitive\":\"string\"}")]
            public string Lockspace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Configures the target device or resource path associated with this lease (for example, a disk path or volume name);</summary>
            /// <remarks>
            /// value is user-provided.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#target Domain#target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesLeasesTarget\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesLeasesTarget? Target
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesLeasesTarget?>();
            }
        }
    }
}
