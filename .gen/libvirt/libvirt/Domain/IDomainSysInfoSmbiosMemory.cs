using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainSysInfoSmbiosMemory), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbiosMemory")]
    public interface IDomainSysInfoSmbiosMemory
    {
        /// <summary>Defines a single SMBIOS memory information field override, identified by its required name and provided via value or file.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#entry Domain#entry}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosMemoryEntry" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosMemoryEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Entry
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainSysInfoSmbiosMemory), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbiosMemory")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainSysInfoSmbiosMemory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines a single SMBIOS memory information field override, identified by its required name and provided via value or file.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#entry Domain#entry}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosMemoryEntry" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosMemoryEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Entry
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
