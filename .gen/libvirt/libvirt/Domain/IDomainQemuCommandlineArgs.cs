using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainQemuCommandlineArgs), fullyQualifiedName: "libvirt.domain.DomainQemuCommandlineArgs")]
    public interface IDomainQemuCommandlineArgs
    {
        /// <summary>Sets one QEMU command-line argument token exactly as passed to the QEMU process;</summary>
        /// <remarks>
        /// values that conceptually belong together must still be provided as separate entries.
        ///
        /// See: <a href="https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions">https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainQemuCommandlineArgs), fullyQualifiedName: "libvirt.domain.DomainQemuCommandlineArgs")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainQemuCommandlineArgs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets one QEMU command-line argument token exactly as passed to the QEMU process;</summary>
            /// <remarks>
            /// values that conceptually belong together must still be provided as separate entries.
            ///
            /// See: <a href="https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions">https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions</a>
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
