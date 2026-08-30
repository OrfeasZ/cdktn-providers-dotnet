using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "libvirt.domain.DomainDevicesRngsRate")]
    public class DomainDevicesRngsRate : libvirt.Domain.IDomainDevicesRngsRate
    {
        /// <summary>Sets the maximum number of bytes of random data the RNG device may deliver per period;</summary>
        /// <remarks>
        /// required and must be a positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#bytes Domain#bytes}
        /// </remarks>
        [JsiiProperty(name: "bytes", typeJson: "{\"primitive\":\"number\"}")]
        public double Bytes
        {
            get;
            set;
        }

        /// <summary>Sets the length of the rate limiting period in seconds for the RNG device; optional, user-provided non‑negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#period Domain#period}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Period
        {
            get;
            set;
        }
    }
}
