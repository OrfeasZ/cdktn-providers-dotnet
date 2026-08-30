using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainQemuOverrideDevicesFrontend), fullyQualifiedName: "libvirt.domain.DomainQemuOverrideDevicesFrontend")]
    public interface IDomainQemuOverrideDevicesFrontend
    {
        /// <summary>Lists individual QEMU frontend properties to override on the selected device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#properties Domain#properties}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuOverrideDevicesFrontendProperties" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "properties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuOverrideDevicesFrontendProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Properties
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainQemuOverrideDevicesFrontend), fullyQualifiedName: "libvirt.domain.DomainQemuOverrideDevicesFrontend")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainQemuOverrideDevicesFrontend
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Lists individual QEMU frontend properties to override on the selected device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#properties Domain#properties}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="libvirt.Domain.IDomainQemuOverrideDevicesFrontendProperties" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "properties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuOverrideDevicesFrontendProperties\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Properties
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
