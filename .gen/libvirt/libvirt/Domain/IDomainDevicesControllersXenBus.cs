using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesControllersXenBus), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersXenBus")]
    public interface IDomainDevicesControllersXenBus
    {
        /// <summary>Sets the maximum number of Xen event channels available via this Xen bus controller;</summary>
        /// <remarks>
        /// value is a user-provided positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max_event_channels Domain#max_event_channels}
        /// </remarks>
        [JsiiProperty(name: "maxEventChannels", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxEventChannels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the maximum number of grant frames for shared memory operations on this Xen bus controller;</summary>
        /// <remarks>
        /// value is a user-provided positive integer.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max_grant_frames Domain#max_grant_frames}
        /// </remarks>
        [JsiiProperty(name: "maxGrantFrames", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxGrantFrames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesControllersXenBus), fullyQualifiedName: "libvirt.domain.DomainDevicesControllersXenBus")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesControllersXenBus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the maximum number of Xen event channels available via this Xen bus controller;</summary>
            /// <remarks>
            /// value is a user-provided positive integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max_event_channels Domain#max_event_channels}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxEventChannels", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxEventChannels
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Sets the maximum number of grant frames for shared memory operations on this Xen bus controller;</summary>
            /// <remarks>
            /// value is a user-provided positive integer.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#controllers">https://libvirt.org/formatdomain.html#controllers</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#max_grant_frames Domain#max_grant_frames}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxGrantFrames", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxGrantFrames
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
