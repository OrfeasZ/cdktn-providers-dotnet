using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainSysInfoSmbiosBaseBoard), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbiosBaseBoard")]
    public interface IDomainSysInfoSmbiosBaseBoard
    {
        /// <summary>Defines one SMBIOS base board field/value pair (for example, product name or serial) that will be visible to the guest via tools like dmidecode.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#entry Domain#entry}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosBaseBoardEntry" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBaseBoardEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Entry
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainSysInfoSmbiosBaseBoard), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbiosBaseBoard")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainSysInfoSmbiosBaseBoard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines one SMBIOS base board field/value pair (for example, product name or serial) that will be visible to the guest via tools like dmidecode.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#entry Domain#entry}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosBaseBoardEntry" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosBaseBoardEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Entry
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
