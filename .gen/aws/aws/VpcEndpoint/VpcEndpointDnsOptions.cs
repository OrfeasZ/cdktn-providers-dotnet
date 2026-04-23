using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpcEndpoint
{
    [JsiiByValue(fqn: "aws.vpcEndpoint.VpcEndpointDnsOptions")]
    public class VpcEndpointDnsOptions : aws.VpcEndpoint.IVpcEndpointDnsOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_endpoint#dns_record_ip_type VpcEndpoint#dns_record_ip_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsRecordIpType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsRecordIpType
        {
            get;
            set;
        }

        private object? _privateDnsOnlyForInboundResolverEndpoint;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_endpoint#private_dns_only_for_inbound_resolver_endpoint VpcEndpoint#private_dns_only_for_inbound_resolver_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateDnsOnlyForInboundResolverEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PrivateDnsOnlyForInboundResolverEndpoint
        {
            get => _privateDnsOnlyForInboundResolverEndpoint;
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
                _privateDnsOnlyForInboundResolverEndpoint = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_endpoint#private_dns_preference VpcEndpoint#private_dns_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateDnsPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateDnsPreference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/vpc_endpoint#private_dns_specified_domains VpcEndpoint#private_dns_specified_domains}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateDnsSpecifiedDomains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PrivateDnsSpecifiedDomains
        {
            get;
            set;
        }
    }
}
