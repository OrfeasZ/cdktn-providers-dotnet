using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesChannelsTargetXen), fullyQualifiedName: "libvirt.domain.DomainDevicesChannelsTargetXen")]
    public interface IDomainDevicesChannelsTargetXen
    {
        /// <summary>Sets the Xen guest channel name used inside the guest to identify this channel; value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#channel">https://libvirt.org/formatdomain.html#channel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the initial connection state of the Xen channel target; typically "connected" or "disconnected" when supported, value is user-provided.</summary>
        /// <remarks>
        /// See: <a href="https://libvirt.org/formatdomain.html#channel">https://libvirt.org/formatdomain.html#channel</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#state Domain#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesChannelsTargetXen), fullyQualifiedName: "libvirt.domain.DomainDevicesChannelsTargetXen")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesChannelsTargetXen
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the Xen guest channel name used inside the guest to identify this channel; value is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#channel">https://libvirt.org/formatdomain.html#channel</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#name Domain#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the initial connection state of the Xen channel target; typically "connected" or "disconnected" when supported, value is user-provided.</summary>
            /// <remarks>
            /// See: <a href="https://libvirt.org/formatdomain.html#channel">https://libvirt.org/formatdomain.html#channel</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#state Domain#state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
