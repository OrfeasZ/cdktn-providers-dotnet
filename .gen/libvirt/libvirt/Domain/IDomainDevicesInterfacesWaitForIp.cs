using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainDevicesInterfacesWaitForIp), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesWaitForIp")]
    public interface IDomainDevicesInterfacesWaitForIp
    {
        /// <summary>CIDR network prefix to wait for (e.g. "0.0.0.0/0" for any IPv4, "::/0" for any IPv6). If omitted, any address satisfies the wait. Matching is by CIDR membership only; loopback and link-local addresses are not excluded (127.0.0.1 matches 0.0.0.0/0). To wait for a routable address, specify your subnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#network Domain#network}
        /// </remarks>
        [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Network
        {
            get
            {
                return null;
            }
        }

        /// <summary>Source to query for IP addresses: 'lease', 'agent', or 'any'. Default: 'any'.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>Maximum time to wait for IP address in seconds. Default: 300.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#timeout Domain#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainDevicesInterfacesWaitForIp), fullyQualifiedName: "libvirt.domain.DomainDevicesInterfacesWaitForIp")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainDevicesInterfacesWaitForIp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>CIDR network prefix to wait for (e.g. "0.0.0.0/0" for any IPv4, "::/0" for any IPv6). If omitted, any address satisfies the wait. Matching is by CIDR membership only; loopback and link-local addresses are not excluded (127.0.0.1 matches 0.0.0.0/0). To wait for a routable address, specify your subnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#network Domain#network}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Network
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Source to query for IP addresses: 'lease', 'agent', or 'any'. Default: 'any'.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#source Domain#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Source
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Maximum time to wait for IP address in seconds. Default: 300.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#timeout Domain#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
