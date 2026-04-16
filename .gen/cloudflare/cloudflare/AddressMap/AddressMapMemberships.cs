using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AddressMap
{
    [JsiiByValue(fqn: "cloudflare.addressMap.AddressMapMemberships")]
    public class AddressMapMemberships : cloudflare.AddressMap.IAddressMapMemberships
    {
        /// <summary>The identifier for the membership (eg. a zone or account tag).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/address_map#identifier AddressMap#identifier}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Identifier
        {
            get;
            set;
        }

        /// <summary>The type of the membership. Available values: "zone", "account".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/address_map#kind AddressMap#kind}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Kind
        {
            get;
            set;
        }
    }
}
