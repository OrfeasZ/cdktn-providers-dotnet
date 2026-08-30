using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainXenCommandlineArgs), fullyQualifiedName: "libvirt.domain.DomainXenCommandlineArgs")]
    public interface IDomainXenCommandlineArgs
    {
        /// <summary>Sets one additional argument token passed to the Xen qemu device model.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/drvxen.html">https://libvirt.org/drvxen.html</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainXenCommandlineArgs), fullyQualifiedName: "libvirt.domain.DomainXenCommandlineArgs")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainXenCommandlineArgs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets one additional argument token passed to the Xen qemu device model.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/drvxen.html">https://libvirt.org/drvxen.html</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
