using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsSteeringPolicy
{
    [JsiiInterface(nativeType: typeof(IDnsSteeringPolicyRules), fullyQualifiedName: "oci.dnsSteeringPolicy.DnsSteeringPolicyRules")]
    public interface IDnsSteeringPolicyRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#rule_type DnsSteeringPolicy#rule_type}.</summary>
        [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
        string RuleType
        {
            get;
        }

        /// <summary>cases block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#cases DnsSteeringPolicy#cases}
        /// </remarks>
        [JsiiProperty(name: "cases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dnsSteeringPolicy.DnsSteeringPolicyRulesCases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Cases
        {
            get
            {
                return null;
            }
        }

        /// <summary>default_answer_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#default_answer_data DnsSteeringPolicy#default_answer_data}
        /// </remarks>
        [JsiiProperty(name: "defaultAnswerData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dnsSteeringPolicy.DnsSteeringPolicyRulesDefaultAnswerData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultAnswerData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#default_count DnsSteeringPolicy#default_count}.</summary>
        [JsiiProperty(name: "defaultCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#description DnsSteeringPolicy#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsSteeringPolicyRules), fullyQualifiedName: "oci.dnsSteeringPolicy.DnsSteeringPolicyRules")]
        internal sealed class _Proxy : DeputyBase, oci.DnsSteeringPolicy.IDnsSteeringPolicyRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#rule_type DnsSteeringPolicy#rule_type}.</summary>
            [JsiiProperty(name: "ruleType", typeJson: "{\"primitive\":\"string\"}")]
            public string RuleType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cases block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#cases DnsSteeringPolicy#cases}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cases", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dnsSteeringPolicy.DnsSteeringPolicyRulesCases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Cases
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>default_answer_data block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#default_answer_data DnsSteeringPolicy#default_answer_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultAnswerData", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dnsSteeringPolicy.DnsSteeringPolicyRulesDefaultAnswerData\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DefaultAnswerData
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#default_count DnsSteeringPolicy#default_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#description DnsSteeringPolicy#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
