using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesConsolesTarget), fullyQualifiedName: "libvirt.domain.DomainDevicesConsolesTarget")]
    public interface IDomainDevicesConsolesTarget
    {
        /// <summary>Sets the guest-side console port number, starting from 0; the value is a user-provided non-negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#guest-interface">https://libvirt.org/formatdomain.html#guest-interface</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the target device type for the console within the guest (e.g. "serial", "virtio", "xen", "sclp"); the value must match a libvirt-supported console type.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#guest-interface">https://libvirt.org/formatdomain.html#guest-interface</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesConsolesTarget), fullyQualifiedName: "libvirt.domain.DomainDevicesConsolesTarget")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesConsolesTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the guest-side console port number, starting from 0; the value is a user-provided non-negative integer.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#guest-interface">https://libvirt.org/formatdomain.html#guest-interface</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#port Domain#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the target device type for the console within the guest (e.g. "serial", "virtio", "xen", "sclp"); the value must match a libvirt-supported console type.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#guest-interface">https://libvirt.org/formatdomain.html#guest-interface</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#type Domain#type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
