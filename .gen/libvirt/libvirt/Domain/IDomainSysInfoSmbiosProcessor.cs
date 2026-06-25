using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainSysInfoSmbiosProcessor), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbiosProcessor")]
    public interface IDomainSysInfoSmbiosProcessor
    {
        /// <summary>Defines a single SMBIOS processor field override, identified by its required name and a user-provided value or file-backed value (for example, customizing processor version or manufacturer).</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#entry Domain#entry}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosProcessorEntry" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosProcessorEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Entry
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainSysInfoSmbiosProcessor), fullyQualifiedName: "libvirt.domain.DomainSysInfoSmbiosProcessor")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainSysInfoSmbiosProcessor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Defines a single SMBIOS processor field override, identified by its required name and a user-provided value or file-backed value (for example, customizing processor version or manufacturer).</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#smbios-system-information">https://libvirt.org/formatdomain.html#smbios-system-information</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#entry Domain#entry}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainSysInfoSmbiosProcessorEntry" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "entry", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainSysInfoSmbiosProcessorEntry\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Entry
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
