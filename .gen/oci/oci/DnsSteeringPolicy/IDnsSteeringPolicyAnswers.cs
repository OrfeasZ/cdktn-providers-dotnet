using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DnsSteeringPolicy
{
    [JsiiInterface(nativeType: typeof(IDnsSteeringPolicyAnswers), fullyQualifiedName: "oci.dnsSteeringPolicy.DnsSteeringPolicyAnswers")]
    public interface IDnsSteeringPolicyAnswers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#name DnsSteeringPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#rdata DnsSteeringPolicy#rdata}.</summary>
        [JsiiProperty(name: "rdata", typeJson: "{\"primitive\":\"string\"}")]
        string Rdata
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#rtype DnsSteeringPolicy#rtype}.</summary>
        [JsiiProperty(name: "rtype", typeJson: "{\"primitive\":\"string\"}")]
        string Rtype
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#is_disabled DnsSteeringPolicy#is_disabled}.</summary>
        [JsiiProperty(name: "isDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#pool DnsSteeringPolicy#pool}.</summary>
        [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Pool
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDnsSteeringPolicyAnswers), fullyQualifiedName: "oci.dnsSteeringPolicy.DnsSteeringPolicyAnswers")]
        internal sealed class _Proxy : DeputyBase, oci.DnsSteeringPolicy.IDnsSteeringPolicyAnswers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#name DnsSteeringPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#rdata DnsSteeringPolicy#rdata}.</summary>
            [JsiiProperty(name: "rdata", typeJson: "{\"primitive\":\"string\"}")]
            public string Rdata
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#rtype DnsSteeringPolicy#rtype}.</summary>
            [JsiiProperty(name: "rtype", typeJson: "{\"primitive\":\"string\"}")]
            public string Rtype
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#is_disabled DnsSteeringPolicy#is_disabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dns_steering_policy#pool DnsSteeringPolicy#pool}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Pool
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
