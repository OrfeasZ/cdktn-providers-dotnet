using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesRngsRate), fullyQualifiedName: "libvirt.domain.DomainDevicesRngsRate")]
    public interface IDomainDevicesRngsRate
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
        double Bytes
        {
            get;
        }

        /// <summary>Sets the length of the rate limiting period in seconds for the RNG device; optional, user-provided non‑negative integer.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#random-number-generator-device">https://libvirt.org/formatdomain.html#random-number-generator-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#period Domain#period}
        /// </remarks>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Period
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesRngsRate), fullyQualifiedName: "libvirt.domain.DomainDevicesRngsRate")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesRngsRate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<double>()!;
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
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
