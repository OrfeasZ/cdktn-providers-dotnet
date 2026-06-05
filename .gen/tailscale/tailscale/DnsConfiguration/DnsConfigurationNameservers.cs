using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.DnsConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "tailscale.dnsConfiguration.DnsConfigurationNameservers")]
    public class DnsConfigurationNameservers : tailscale.DnsConfiguration.IDnsConfigurationNameservers
    {
        /// <summary>The nameserver's IPv4 or IPv6 address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#address DnsConfiguration#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        private object? _useWithExitNode;

        /// <summary>This nameserver will continue to be used when an exit node is selected (requires Tailscale v1.88.1 or later). Defaults to false.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/resources/dns_configuration#use_with_exit_node DnsConfiguration#use_with_exit_node}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useWithExitNode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseWithExitNode
        {
            get => _useWithExitNode;
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
                _useWithExitNode = value;
            }
        }
    }
}
