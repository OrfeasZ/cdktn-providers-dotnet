using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosFileInput), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosFileInput")]
    public interface IDomainDevicesAudiosFileInput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#buffer_length Domain#buffer_length}.</summary>
        [JsiiProperty(name: "bufferLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BufferLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fixed_settings Domain#fixed_settings}.</summary>
        [JsiiProperty(name: "fixedSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FixedSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mixing_engine Domain#mixing_engine}.</summary>
        [JsiiProperty(name: "mixingEngine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MixingEngine
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#settings Domain#settings}.</summary>
        [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFileInputSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        libvirt.Domain.IDomainDevicesAudiosFileInputSettings? Settings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#voices Domain#voices}.</summary>
        [JsiiProperty(name: "voices", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Voices
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosFileInput), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosFileInput")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosFileInput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#buffer_length Domain#buffer_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bufferLength", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BufferLength
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fixed_settings Domain#fixed_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fixedSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FixedSettings
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#mixing_engine Domain#mixing_engine}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mixingEngine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MixingEngine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#settings Domain#settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "settings", typeJson: "{\"fqn\":\"libvirt.domain.DomainDevicesAudiosFileInputSettings\"}", isOptional: true)]
            public libvirt.Domain.IDomainDevicesAudiosFileInputSettings? Settings
            {
                get => GetInstanceProperty<libvirt.Domain.IDomainDevicesAudiosFileInputSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#voices Domain#voices}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "voices", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Voices
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
