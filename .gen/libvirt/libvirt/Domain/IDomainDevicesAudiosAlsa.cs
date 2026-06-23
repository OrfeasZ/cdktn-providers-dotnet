using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosAlsa), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosAlsa")]
    public interface IDomainDevicesAudiosAlsa
    {
        /// <summary>Configures ALSA output (playback) settings for the audio backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsaInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosAlsaInput? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures ALSA output (playback) settings for the audio backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsaOutput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosAlsaOutput? Output
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosAlsa), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosAlsa")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosAlsa
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures ALSA output (playback) settings for the audio backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#input Domain#input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsaInput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosAlsaInput? Input
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosAlsaInput?>();
            }

            /// <summary>Configures ALSA output (playback) settings for the audio backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#output Domain#output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosAlsaOutput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosAlsaOutput? Output
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosAlsaOutput?>();
            }
        }
    }
}
