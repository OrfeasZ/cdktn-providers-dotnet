using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainQemuCommandlineEnvs), fullyQualifiedName: "libvirt.domain.DomainQemuCommandlineEnvs")]
    public interface IDomainQemuCommandlineEnvs
    {
        /// <summary>Sets the environment variable name passed to QEMU, such as `QEMU_AUDIO_DRV`.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions">https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Sets the optional value for the named QEMU environment variable;</summary>
        /// <remarks>
        /// if omitted, the variable is declared without an explicit value.
        ///
        /// See: <a href="https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions">https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainQemuCommandlineEnvs), fullyQualifiedName: "libvirt.domain.DomainQemuCommandlineEnvs")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainQemuCommandlineEnvs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the environment variable name passed to QEMU, such as `QEMU_AUDIO_DRV`.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions">https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Sets the optional value for the named QEMU environment variable;</summary>
            /// <remarks>
            /// if omitted, the variable is declared without an explicit value.
            ///
            /// See: <a href="https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions">https://libvirt.org/kbase/qemu-passthrough-security.html#xml-document-additions</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#value Domain#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
