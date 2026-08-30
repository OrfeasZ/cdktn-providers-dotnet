using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosCoreAudio), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosCoreAudio")]
    public interface IDomainDevicesAudiosCoreAudio
    {
        /// <summary>Configures CoreAudio output (playback) parameters for the audio backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosCoreAudioInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosCoreAudioInput? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configures CoreAudio output (playback) parameters for the audio backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosCoreAudioOutput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosCoreAudioOutput? Output
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosCoreAudio), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosCoreAudio")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosCoreAudio
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configures CoreAudio output (playback) parameters for the audio backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosCoreAudioInput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosCoreAudioInput? Input
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosCoreAudioInput?>();
            }

            /// <summary>Configures CoreAudio output (playback) parameters for the audio backend.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosCoreAudioOutput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosCoreAudioOutput? Output
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosCoreAudioOutput?>();
            }
        }
    }
}
