using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsSteeringPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dnsSteeringPolicy.DnsSteeringPolicyRules")]
    public class DnsSteeringPolicyRules : oci.DnsSteeringPolicy.IDnsSteeringPolicyRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#rule_type DnsSteeringPolicy#rule_type}.</summary>
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
        public string RuleType
        {
            get;
            set;
        }

        private object? _cases;

        /// <summary>cases block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#cases DnsSteeringPolicy#cases}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dnsSteeringPolicy.DnsSteeringPolicyRulesCases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Cases
        {
            get => _cases;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DnsSteeringPolicy.IDnsSteeringPolicyRulesCases[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DnsSteeringPolicy.IDnsSteeringPolicyRulesCases).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cases = value;
            }
        }

        private object? _defaultAnswerData;

        /// <summary>default_answer_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#default_answer_data DnsSteeringPolicy#default_answer_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultAnswerData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dnsSteeringPolicy.DnsSteeringPolicyRulesDefaultAnswerData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DefaultAnswerData
        {
            get => _defaultAnswerData;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DnsSteeringPolicy.IDnsSteeringPolicyRulesDefaultAnswerData[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DnsSteeringPolicy.IDnsSteeringPolicyRulesDefaultAnswerData).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _defaultAnswerData = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#default_count DnsSteeringPolicy#default_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DefaultCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#description DnsSteeringPolicy#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
