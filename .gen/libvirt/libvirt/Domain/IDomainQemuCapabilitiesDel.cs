using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainQemuCapabilitiesDel), fullyQualifiedName: "libvirt.domain.DomainQemuCapabilitiesDel")]
    public interface IDomainQemuCapabilitiesDel
    {
        /// <summary>Sets the QEMU capability name referenced by this entry, using the capability identifier expected by libvirt and the QEMU driver;</summary>
        /// <remarks>
        /// whether it is added or removed depends on whether the entry is placed under <c>add</c> or <c>del</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainQemuCapabilitiesDel), fullyQualifiedName: "libvirt.domain.DomainQemuCapabilitiesDel")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainQemuCapabilitiesDel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the QEMU capability name referenced by this entry, using the capability identifier expected by libvirt and the QEMU driver;</summary>
            /// <remarks>
            /// whether it is added or removed depends on whether the entry is placed under <c>add</c> or <c>del</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
