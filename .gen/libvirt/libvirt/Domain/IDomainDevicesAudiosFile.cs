using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosFile), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosFile")]
    public interface IDomainDevicesAudiosFile
    {
        /// <summary>Enables and configures the output (playback) side of the file audio backend;</summary>
        /// <remarks>
        /// presence controls whether guest output audio is written to file.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
        /// </remarks>
        [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFileInput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosFileInput? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enables and configures the output (playback) side of the file audio backend;</summary>
        /// <remarks>
        /// presence controls whether guest output audio is written to file.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
        /// </remarks>
        [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFileOutput\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosFileOutput? Output
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the host file path used by the file audio backend to store the recorded audio stream;</summary>
        /// <remarks>
        /// the value is a user-provided filesystem path (for example, <c>/var/lib/libvirt/sound.wav</c>).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#file-audio-backend">https://libvirt.org/formatdomain.html#file-audio-backend</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosFile), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosFile")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Enables and configures the output (playback) side of the file audio backend;</summary>
            /// <remarks>
            /// presence controls whether guest output audio is written to file.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#input Domain#input}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFileInput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosFileInput? Input
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosFileInput?>();
            }

            /// <summary>Enables and configures the output (playback) side of the file audio backend;</summary>
            /// <remarks>
            /// presence controls whether guest output audio is written to file.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#output Domain#output}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "output", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFileOutput\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosFileOutput? Output
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosFileOutput?>();
            }

            /// <summary>Sets the host file path used by the file audio backend to store the recorded audio stream;</summary>
            /// <remarks>
            /// the value is a user-provided filesystem path (for example, <c>/var/lib/libvirt/sound.wav</c>).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#file-audio-backend">https://libvirt.org/formatdomain.html#file-audio-backend</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#path Domain#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
