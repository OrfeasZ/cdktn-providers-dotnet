using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesMemBalloonStats), fullyQualifiedName: "libvirt.domain.DomainDevicesMemBalloonStats")]
    public interface IDomainDevicesMemBalloonStats
    {
        /// <summary>Sets the polling period in seconds for collecting memory balloon statistics;</summary>
        /// <remarks>
        /// use 0 to disable statistics, or a positive integer interval.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#memory-balloon-device">https://libvirt.org/formatdomain.html#memory-balloon-device</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#period Domain#period}
        /// </remarks>
        [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
        double Period
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesMemBalloonStats), fullyQualifiedName: "libvirt.domain.DomainDevicesMemBalloonStats")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesMemBalloonStats
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the polling period in seconds for collecting memory balloon statistics;</summary>
            /// <remarks>
            /// use 0 to disable statistics, or a positive integer interval.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#memory-balloon-device">https://libvirt.org/formatdomain.html#memory-balloon-device</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/resources/domain#period Domain#period}
            /// </remarks>
            [JsiiProperty(name: "period", typeJson: "{\"primitive\":\"number\"}")]
            public double Period
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
