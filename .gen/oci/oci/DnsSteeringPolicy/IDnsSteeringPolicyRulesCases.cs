using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsSteeringPolicy
{
    [JsiiInterface(nativeType: typeof(IDnsSteeringPolicyRulesCases), fullyQualifiedName: "oci.dnsSteeringPolicy.DnsSteeringPolicyRulesCases")]
    public interface IDnsSteeringPolicyRulesCases
    {
        /// <summary>answer_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#answer_data DnsSteeringPolicy#answer_data}
        /// </remarks>
        [JsiiProperty(name: "answerData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dnsSteeringPolicy.DnsSteeringPolicyRulesCasesAnswerData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AnswerData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#case_condition DnsSteeringPolicy#case_condition}.</summary>
        [JsiiProperty(name: "caseCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaseCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#count DnsSteeringPolicy#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Count
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsSteeringPolicyRulesCases), fullyQualifiedName: "oci.dnsSteeringPolicy.DnsSteeringPolicyRulesCases")]
        internal sealed class _Proxy : DeputyBase, oci.DnsSteeringPolicy.IDnsSteeringPolicyRulesCases
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>answer_data block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#answer_data DnsSteeringPolicy#answer_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "answerData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dnsSteeringPolicy.DnsSteeringPolicyRulesCasesAnswerData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AnswerData
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#case_condition DnsSteeringPolicy#case_condition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caseCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaseCondition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#count DnsSteeringPolicy#count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
