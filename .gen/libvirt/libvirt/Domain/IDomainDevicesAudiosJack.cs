using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosJack), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosJack")]
    public interface IDomainDevicesAudiosJack
    {
        /// <summary>Enables and configures the output (playback) side of the Jack audio backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosJackInput? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures the output (playback) side of the Jack audio backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackOutput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosJackOutput? Output
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosJack), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosJack")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosJack
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables and configures the output (playback) side of the Jack audio backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackInput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosJackInput? Input
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosJackInput?>();
            }

            /// <summary>Enables and configures the output (playback) side of the Jack audio backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosJackOutput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosJackOutput? Output
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosJackOutput?>();
            }
        }
    }
}
