using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceSecurityGroup
{
    [JsiiInterface(nativeType: typeof(IInstanceSecurityGroupOutboundRule), fullyQualifiedName: "scaleway.instanceSecurityGroup.InstanceSecurityGroupOutboundRule")]
    public interface IInstanceSecurityGroupOutboundRule
    {
        /// <summary>Action when rule match request (drop or accept).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#action InstanceSecurityGroup#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Ip address for this rule (e.g: 1.1.1.1). Only one of ip or ip_range should be provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#ip InstanceSecurityGroup#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>Ip range for this rule (e.g: 192.168.1.0/24). Only one of ip or ip_range should be provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#ip_range InstanceSecurityGroup#ip_range}
        /// </remarks>
        [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>Network port for this rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#port InstanceSecurityGroup#port}
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Computed port range for this rule (e.g: 1-1024, 22-22).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#port_range InstanceSecurityGroup#port_range}
        /// </remarks>
        [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PortRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>Protocol for this rule (TCP, UDP, ICMP or ANY).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#protocol InstanceSecurityGroup#protocol}
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceSecurityGroupOutboundRule), fullyQualifiedName: "scaleway.instanceSecurityGroup.InstanceSecurityGroupOutboundRule")]
        internal sealed class _Proxy : DeputyBase, scaleway.InstanceSecurityGroup.IInstanceSecurityGroupOutboundRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Action when rule match request (drop or accept).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#action InstanceSecurityGroup#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Ip address for this rule (e.g: 1.1.1.1). Only one of ip or ip_range should be provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#ip InstanceSecurityGroup#ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Ip range for this rule (e.g: 192.168.1.0/24). Only one of ip or ip_range should be provided.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#ip_range InstanceSecurityGroup#ip_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpRange
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Network port for this rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#port InstanceSecurityGroup#port}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Computed port range for this rule (e.g: 1-1024, 22-22).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#port_range InstanceSecurityGroup#port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PortRange
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Protocol for this rule (TCP, UDP, ICMP or ANY).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_security_group#protocol InstanceSecurityGroup#protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
