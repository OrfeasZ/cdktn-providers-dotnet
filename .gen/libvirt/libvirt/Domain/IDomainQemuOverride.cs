using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainQemuOverride), fullyQualifiedName: "libvirt.domain.DomainQemuOverride")]
    public interface IDomainQemuOverride
    {
        /// <summary>Lists device-specific QEMU overrides, each matched by device alias and carrying frontend property overrides.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#devices Domain#devices}
        /// </remarks>
        [JsiiProperty(name: "devices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuOverrideDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Devices
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainQemuOverride), fullyQualifiedName: "libvirt.domain.DomainQemuOverride")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainQemuOverride
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Lists device-specific QEMU overrides, each matched by device alias and carrying frontend property overrides.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#devices Domain#devices}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "devices", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"libvirt.domain.DomainQemuOverrideDevices\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Devices
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
