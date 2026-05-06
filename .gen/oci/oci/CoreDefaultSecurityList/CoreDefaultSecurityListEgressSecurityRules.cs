using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDefaultSecurityList
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRules")]
    public class CoreDefaultSecurityListEgressSecurityRules : oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#destination CoreDefaultSecurityList#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public string Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#protocol CoreDefaultSecurityList#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#description CoreDefaultSecurityList#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#destination_type CoreDefaultSecurityList#destination_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationType
        {
            get;
            set;
        }

        /// <summary>icmp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#icmp_options CoreDefaultSecurityList#icmp_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "icmpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesIcmpOptions\"}", isOptional: true)]
        public oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesIcmpOptions? IcmpOptions
        {
            get;
            set;
        }

        private object? _stateless;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#stateless CoreDefaultSecurityList#stateless}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#tcp_options CoreDefaultSecurityList#tcp_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesTcpOptions\"}", isOptional: true)]
        public oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesTcpOptions? TcpOptions
        {
            get;
            set;
        }

        /// <summary>udp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_default_security_list#udp_options CoreDefaultSecurityList#udp_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "udpOptions", typeJson: "{\"fqn\":\"oci.coreDefaultSecurityList.CoreDefaultSecurityListEgressSecurityRulesUdpOptions\"}", isOptional: true)]
        public oci.CoreDefaultSecurityList.ICoreDefaultSecurityListEgressSecurityRulesUdpOptions? UdpOptions
        {
            get;
            set;
        }
    }
}
