using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesChannelsLog")]
    public class DomainDevicesChannelsLog : libvirt.Domain.IDomainDevicesChannelsLog
    {
        /// <summary>Sets the absolute or relative path of the host file where channel I/O is logged.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#device-logfile">https://libvirt.org/formatdomain.html#device-logfile</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#file Domain#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        public string File
        {
            get;
            set;
        }

        /// <summary>Controls whether the channel log file is appended to (`"yes"`) or truncated (`"no"`) on start;</summary>
        /// <remarks>
        /// this is a yes/no string flag.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#device-logfile">https://libvirt.org/formatdomain.html#device-logfile</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#append Domain#append}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "append", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Append
        {
            get;
            set;
        }
    }
}
