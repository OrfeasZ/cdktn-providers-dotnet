using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceSecurityGroupRules
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.instanceSecurityGroupRules.InstanceSecurityGroupRulesInboundRule")]
    public class InstanceSecurityGroupRulesInboundRule : scaleway.InstanceSecurityGroupRules.IInstanceSecurityGroupRulesInboundRule
    {
        /// <summary>Action when rule match request (drop or accept).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_security_group_rules#action InstanceSecurityGroupRules#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Ip address for this rule (e.g: 1.1.1.1). Only one of ip or ip_range should be provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_security_group_rules#ip InstanceSecurityGroupRules#ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ip
        {
            get;
            set;
        }

        /// <summary>Ip range for this rule (e.g: 192.168.1.0/24). Only one of ip or ip_range should be provided.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_security_group_rules#ip_range InstanceSecurityGroupRules#ip_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpRange
        {
            get;
            set;
        }

        /// <summary>Network port for this rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_security_group_rules#port InstanceSecurityGroupRules#port}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Computed port range for this rule (e.g: 1-1024, 22-22).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_security_group_rules#port_range InstanceSecurityGroupRules#port_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portRange", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PortRange
        {
            get;
            set;
        }

        /// <summary>Protocol for this rule (TCP, UDP, ICMP or ANY).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_security_group_rules#protocol InstanceSecurityGroupRules#protocol}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }
    }
}
