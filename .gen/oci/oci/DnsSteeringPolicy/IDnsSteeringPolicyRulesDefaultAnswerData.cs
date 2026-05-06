using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsSteeringPolicy
{
    [JsiiInterface(nativeType: typeof(IDnsSteeringPolicyRulesDefaultAnswerData), fullyQualifiedName: "oci.dnsSteeringPolicy.DnsSteeringPolicyRulesDefaultAnswerData")]
    public interface IDnsSteeringPolicyRulesDefaultAnswerData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#answer_condition DnsSteeringPolicy#answer_condition}.</summary>
        [JsiiProperty(name: "answerCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AnswerCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#should_keep DnsSteeringPolicy#should_keep}.</summary>
        [JsiiProperty(name: "shouldKeep", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShouldKeep
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#value DnsSteeringPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsSteeringPolicyRulesDefaultAnswerData), fullyQualifiedName: "oci.dnsSteeringPolicy.DnsSteeringPolicyRulesDefaultAnswerData")]
        internal sealed class _Proxy : DeputyBase, oci.DnsSteeringPolicy.IDnsSteeringPolicyRulesDefaultAnswerData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#answer_condition DnsSteeringPolicy#answer_condition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "answerCondition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AnswerCondition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#should_keep DnsSteeringPolicy#should_keep}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shouldKeep", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ShouldKeep
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#value DnsSteeringPolicy#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Value
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
