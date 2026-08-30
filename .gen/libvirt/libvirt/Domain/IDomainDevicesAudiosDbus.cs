using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosDbus), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosDbus")]
    public interface IDomainDevicesAudiosDbus
    {
        /// <summary>Enables and configures output (playback) for the D‑Bus audio backend; no additional attributes are defined beyond presence.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosDbusInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosDbusInput? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures output (playback) for the D‑Bus audio backend; no additional attributes are defined beyond presence.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosDbusOutput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosDbusOutput? Output
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosDbus), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosDbus")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosDbus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables and configures output (playback) for the D‑Bus audio backend; no additional attributes are defined beyond presence.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosDbusInput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosDbusInput? Input
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosDbusInput?>();
            }

            /// <summary>Enables and configures output (playback) for the D‑Bus audio backend; no additional attributes are defined beyond presence.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosDbusOutput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosDbusOutput? Output
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosDbusOutput?>();
            }
        }
    }
}
