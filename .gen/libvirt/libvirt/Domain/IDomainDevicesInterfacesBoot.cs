using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesBoot), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesBoot")]
    public interface IDomainDevicesInterfacesBoot
    {
        /// <summary>Sets the boot priority for this redirected device, as a positive integer where lower values are tried earlier during guest boot (for example, 1 for first, 2 for second).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#specifying-boot-order">https://libvirt.org/formatdomain.html#specifying-boot-order</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#order Domain#order}
        /// </remarks>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        double Order
        {
            get;
        }

        /// <summary>Sets an optional firmware load parameter string associated with booting from this redirected device, passed to firmware on platforms that support loadparm (e.g. s390x).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#specifying-boot-order">https://libvirt.org/formatdomain.html#specifying-boot-order</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#load_parm Domain#load_parm}
        /// </remarks>
        [JsiiProperty(name: "loadParm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoadParm
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesBoot), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesBoot")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesBoot
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the boot priority for this redirected device, as a positive integer where lower values are tried earlier during guest boot (for example, 1 for first, 2 for second).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#specifying-boot-order">https://libvirt.org/formatdomain.html#specifying-boot-order</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#order Domain#order}
            /// </remarks>
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
            public double Order
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets an optional firmware load parameter string associated with booting from this redirected device, passed to firmware on platforms that support loadparm (e.g. s390x).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#specifying-boot-order">https://libvirt.org/formatdomain.html#specifying-boot-order</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#load_parm Domain#load_parm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadParm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoadParm
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
