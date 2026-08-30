using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesAudiosPipeWireOutputSettings), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosPipeWireOutputSettings")]
    public interface IDomainDevicesAudiosPipeWireOutputSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#channels Domain#channels}.</summary>
        [JsiiProperty(name: "channels", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Channels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#format Domain#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Format
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#frequency Domain#frequency}.</summary>
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Frequency
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesAudiosPipeWireOutputSettings), fullyQualifiedName: "libvirt.domain.DomainDevicesAudiosPipeWireOutputSettings")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesAudiosPipeWireOutputSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#channels Domain#channels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "channels", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Channels
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#format Domain#format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Format
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#frequency Domain#frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Frequency
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
