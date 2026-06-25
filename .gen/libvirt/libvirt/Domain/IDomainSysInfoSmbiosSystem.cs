using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainSysInfoSmbiosSystem), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbiosSystem")]
    public interface IDomainSysInfoSmbiosSystem
    {
        /// <summary>Defines one custom SMBIOS “system” field entry;</summary>
        /// <remarks>
        /// each entry specifies a field <c>name</c> and either an inline <c>value</c> or a <c>file</c> to read the value from.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#entry Domain#entry}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosSystemEntry" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosSystemEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Entry
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainSysInfoSmbiosSystem), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbiosSystem")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainSysInfoSmbiosSystem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines one custom SMBIOS “system” field entry;</summary>
            /// <remarks>
            /// each entry specifies a field <c>name</c> and either an inline <c>value</c> or a <c>file</c> to read the value from.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#entry Domain#entry}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosSystemEntry" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosSystemEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Entry
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
