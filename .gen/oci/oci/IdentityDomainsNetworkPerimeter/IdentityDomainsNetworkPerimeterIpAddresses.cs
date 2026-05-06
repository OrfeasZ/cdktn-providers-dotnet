using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsNetworkPerimeter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsNetworkPerimeter.IdentityDomainsNetworkPerimeterIpAddresses")]
    public class IdentityDomainsNetworkPerimeterIpAddresses : oci.IdentityDomainsNetworkPerimeter.IIdentityDomainsNetworkPerimeterIpAddresses
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_network_perimeter#value IdentityDomainsNetworkPerimeter#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_network_perimeter#type IdentityDomainsNetworkPerimeter#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_network_perimeter#version IdentityDomainsNetworkPerimeter#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
