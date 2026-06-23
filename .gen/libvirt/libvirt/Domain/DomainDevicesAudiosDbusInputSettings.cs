using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesAudiosDbusInputSettings")]
    public class DomainDevicesAudiosDbusInputSettings : libvirt.Domain.IDomainDevicesAudiosDbusInputSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#channels Domain#channels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "channels", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Channels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#format Domain#format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Format
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#frequency Domain#frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "frequency", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Frequency
        {
            get;
            set;
        }
    }
}
