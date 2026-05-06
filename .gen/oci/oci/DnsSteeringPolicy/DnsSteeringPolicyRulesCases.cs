using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsSteeringPolicy
{
    [JsiiByValue(fqn: "oci.dnsSteeringPolicy.DnsSteeringPolicyRulesCases")]
    public class DnsSteeringPolicyRulesCases : oci.DnsSteeringPolicy.IDnsSteeringPolicyRulesCases
    {
        private object? _answerData;

        /// <summary>answer_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#answer_data DnsSteeringPolicy#answer_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "answerData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dnsSteeringPolicy.DnsSteeringPolicyRulesCasesAnswerData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AnswerData
        {
            get => _answerData;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DnsSteeringPolicy.IDnsSteeringPolicyRulesCasesAnswerData[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DnsSteeringPolicy.IDnsSteeringPolicyRulesCasesAnswerData).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _answerData = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#case_condition DnsSteeringPolicy#case_condition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "caseCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaseCondition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#count DnsSteeringPolicy#count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }
    }
}
