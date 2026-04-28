using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbFrontend
{
    [JsiiInterface(nativeType: typeof(ILbFrontendAclMatch), fullyQualifiedName: "scaleway.lbFrontend.LbFrontendAclMatch")]
    public interface ILbFrontendAclMatch
    {
        /// <summary>The HTTP filter to match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#http_filter LbFrontend#http_filter}
        /// </remarks>
        [JsiiProperty(name: "httpFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>You can use this field with http_header_match acl type to set the header name to filter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#http_filter_option LbFrontend#http_filter_option}
        /// </remarks>
        [JsiiProperty(name: "httpFilterOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpFilterOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of possible values to match for the given HTTP filter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#http_filter_value LbFrontend#http_filter_value}
        /// </remarks>
        [JsiiProperty(name: "httpFilterValue", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HttpFilterValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>If set to true, the condition will be of type "unless".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#invert LbFrontend#invert}
        /// </remarks>
        [JsiiProperty(name: "invert", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Invert
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines whether Edge Services IPs should be matched.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#ips_edge_services LbFrontend#ips_edge_services}
        /// </remarks>
        [JsiiProperty(name: "ipsEdgeServices", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IpsEdgeServices
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of IPs or CIDR v4/v6 addresses of the client of the session to match.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#ip_subnet LbFrontend#ip_subnet}
        /// </remarks>
        [JsiiProperty(name: "ipSubnet", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IpSubnet
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbFrontendAclMatch), fullyQualifiedName: "scaleway.lbFrontend.LbFrontendAclMatch")]
        internal sealed class _Proxy : DeputyBase, scaleway.LbFrontend.ILbFrontendAclMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The HTTP filter to match.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#http_filter LbFrontend#http_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpFilter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>You can use this field with http_header_match acl type to set the header name to filter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#http_filter_option LbFrontend#http_filter_option}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpFilterOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpFilterOption
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A list of possible values to match for the given HTTP filter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#http_filter_value LbFrontend#http_filter_value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpFilterValue", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HttpFilterValue
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>If set to true, the condition will be of type "unless".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#invert LbFrontend#invert}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "invert", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Invert
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Defines whether Edge Services IPs should be matched.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#ips_edge_services LbFrontend#ips_edge_services}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipsEdgeServices", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IpsEdgeServices
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A list of IPs or CIDR v4/v6 addresses of the client of the session to match.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/lb_frontend#ip_subnet LbFrontend#ip_subnet}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipSubnet", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IpSubnet
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
