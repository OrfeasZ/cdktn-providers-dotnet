using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreSecurityList
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreSecurityList.CoreSecurityListEgressSecurityRules")]
    public class CoreSecurityListEgressSecurityRules : oci.CoreSecurityList.ICoreSecurityListEgressSecurityRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#destination CoreSecurityList#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public string Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#protocol CoreSecurityList#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#description CoreSecurityList#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#destination_type CoreSecurityList#destination_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationType
        {
            get;
            set;
        }

        /// <summary>icmp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#icmp_options CoreSecurityList#icmp_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesIcmpOptions\"}", isOptional: true)]
        public oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesIcmpOptions? IcmpOptions
        {
            get;
            set;
        }

        private object? _stateless;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#stateless CoreSecurityList#stateless}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stateless", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Stateless
        {
            get => _stateless;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stateless = value;
            }
        }

        /// <summary>tcp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#tcp_options CoreSecurityList#tcp_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesTcpOptions\"}", isOptional: true)]
        public oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesTcpOptions? TcpOptions
        {
            get;
            set;
        }

        /// <summary>udp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_security_list#udp_options CoreSecurityList#udp_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreSecurityList.CoreSecurityListEgressSecurityRulesUdpOptions\"}", isOptional: true)]
        public oci.CoreSecurityList.ICoreSecurityListEgressSecurityRulesUdpOptions? UdpOptions
        {
            get;
            set;
        }
    }
}
