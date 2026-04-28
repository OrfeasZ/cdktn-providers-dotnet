using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbFrontend
{
    [JsiiByValue(fqn: "scaleway.lbFrontend.LbFrontendAclMatch")]
    public class LbFrontendAclMatch : scaleway.LbFrontend.ILbFrontendAclMatch
    {
        /// <summary>The HTTP filter to match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#http_filter LbFrontend#http_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpFilter
        {
            get;
            set;
        }

        /// <summary>You can use this field with http_header_match acl type to set the header name to filter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#http_filter_option LbFrontend#http_filter_option}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpFilterOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpFilterOption
        {
            get;
            set;
        }

        /// <summary>A list of possible values to match for the given HTTP filter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#http_filter_value LbFrontend#http_filter_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpFilterValue", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HttpFilterValue
        {
            get;
            set;
        }

        private object? _invert;

        /// <summary>If set to true, the condition will be of type "unless".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#invert LbFrontend#invert}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "invert", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Invert
        {
            get => _invert;
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
                _invert = value;
            }
        }

        private object? _ipsEdgeServices;

        /// <summary>Defines whether Edge Services IPs should be matched.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#ips_edge_services LbFrontend#ips_edge_services}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipsEdgeServices", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IpsEdgeServices
        {
            get => _ipsEdgeServices;
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
                _ipsEdgeServices = value;
            }
        }

        /// <summary>A list of IPs or CIDR v4/v6 addresses of the client of the session to match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#ip_subnet LbFrontend#ip_subnet}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipSubnet", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpSubnet
        {
            get;
            set;
        }
    }
}
