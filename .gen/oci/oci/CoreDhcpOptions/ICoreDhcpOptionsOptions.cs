using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDhcpOptions
{
    [JsiiInterface(nativeType: typeof(ICoreDhcpOptionsOptions), fullyQualifiedName: "oci.coreDhcpOptions.CoreDhcpOptionsOptions")]
    public interface ICoreDhcpOptionsOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dhcp_options#type CoreDhcpOptions#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dhcp_options#custom_dns_servers CoreDhcpOptions#custom_dns_servers}.</summary>
        [JsiiProperty(name: "customDnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CustomDnsServers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dhcp_options#search_domain_names CoreDhcpOptions#search_domain_names}.</summary>
        [JsiiProperty(name: "searchDomainNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SearchDomainNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dhcp_options#server_type CoreDhcpOptions#server_type}.</summary>
        [JsiiProperty(name: "serverType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServerType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreDhcpOptionsOptions), fullyQualifiedName: "oci.coreDhcpOptions.CoreDhcpOptionsOptions")]
        internal sealed class _Proxy : DeputyBase, oci.CoreDhcpOptions.ICoreDhcpOptionsOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dhcp_options#type CoreDhcpOptions#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dhcp_options#custom_dns_servers CoreDhcpOptions#custom_dns_servers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customDnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CustomDnsServers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dhcp_options#search_domain_names CoreDhcpOptions#search_domain_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "searchDomainNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SearchDomainNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_dhcp_options#server_type CoreDhcpOptions#server_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serverType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServerType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
