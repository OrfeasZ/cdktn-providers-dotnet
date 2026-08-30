using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesControllersNvme), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersNvme")]
    public interface IDomainDevicesControllersNvme
    {
        /// <summary>Sets the NVMe controller serial identifier exposed to the guest;</summary>
        /// <remarks>
        /// the value is user-provided and typically an ASCII string (for example, "nvme0-ctrl1").
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#serial Domain#serial}
        /// </remarks>
        [JsiiProperty(name: "serial", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Serial
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesControllersNvme), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersNvme")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesControllersNvme
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the NVMe controller serial identifier exposed to the guest;</summary>
            /// <remarks>
            /// the value is user-provided and typically an ASCII string (for example, "nvme0-ctrl1").
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#serial Domain#serial}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serial", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Serial
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
