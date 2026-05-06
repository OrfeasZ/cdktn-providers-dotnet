using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsSteeringPolicy
{
    [JsiiByValue(fqn: "oci.dnsSteeringPolicy.DnsSteeringPolicyRulesDefaultAnswerData")]
    public class DnsSteeringPolicyRulesDefaultAnswerData : oci.DnsSteeringPolicy.IDnsSteeringPolicyRulesDefaultAnswerData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#answer_condition DnsSteeringPolicy#answer_condition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "answerCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AnswerCondition
        {
            get;
            set;
        }

        private object? _shouldKeep;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#should_keep DnsSteeringPolicy#should_keep}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shouldKeep", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ShouldKeep
        {
            get => _shouldKeep;
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
                _shouldKeep = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#value DnsSteeringPolicy#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Value
        {
            get;
            set;
        }
    }
}
