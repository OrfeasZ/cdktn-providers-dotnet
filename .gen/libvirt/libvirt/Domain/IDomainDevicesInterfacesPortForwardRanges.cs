using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesPortForwardRanges), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesPortForwardRanges")]
    public interface IDomainDevicesInterfacesPortForwardRanges
    {
        /// <summary>Sets the first host port in the forwarded range;</summary>
        /// <remarks>
        /// must be an integer in the valid TCP/UDP port range (1–65535).
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#start Domain#start}
        /// </remarks>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        double Start
        {
            get;
        }

        /// <summary>Sets the last port in the forwarded range (inclusive);</summary>
        /// <remarks>
        /// if omitted, the range effectively applies only to the start port.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#end Domain#end}
        /// </remarks>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? End
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicates that this range is an exclusion from previously defined inclusive ranges;</summary>
        /// <remarks>
        /// value is user-provided (for example, "yes" or "true") and treated as a presence/flag.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#exclude Domain#exclude}
        /// </remarks>
        [JsiiProperty(name: "exclude", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Exclude
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sets the guest port to which traffic is forwarded;</summary>
        /// <remarks>
        /// if omitted, the guest port defaults to the same number as the host start port.
        ///
        /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#to Domain#to}
        /// </remarks>
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? To
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesPortForwardRanges), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesPortForwardRanges")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesPortForwardRanges
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Sets the first host port in the forwarded range;</summary>
            /// <remarks>
            /// must be an integer in the valid TCP/UDP port range (1–65535).
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#start Domain#start}
            /// </remarks>
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
            public double Start
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Sets the last port in the forwarded range (inclusive);</summary>
            /// <remarks>
            /// if omitted, the range effectively applies only to the start port.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#end Domain#end}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? End
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Indicates that this range is an exclusion from previously defined inclusive ranges;</summary>
            /// <remarks>
            /// value is user-provided (for example, "yes" or "true") and treated as a presence/flag.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#exclude Domain#exclude}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exclude", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Exclude
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sets the guest port to which traffic is forwarded;</summary>
            /// <remarks>
            /// if omitted, the guest port defaults to the same number as the host start port.
            ///
            /// See: <a href="https://libvirt.org/formatdomain.html#userspace-connection-using-passt">https://libvirt.org/formatdomain.html#userspace-connection-using-passt</a>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#to Domain#to}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? To
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
