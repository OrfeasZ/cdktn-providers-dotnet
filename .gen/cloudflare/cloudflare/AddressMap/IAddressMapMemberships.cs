using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AddressMap
{
    [JsiiInterface(nativeType: typeof(IAddressMapMemberships), fullyQualifiedName: "cloudflare.addressMap.AddressMapMemberships")]
    public interface IAddressMapMemberships
    {
        /// <summary>The identifier for the membership (eg. a zone or account tag).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/address_map#identifier AddressMap#identifier}
        /// </remarks>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Identifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>The type of the membership. Available values: "zone", "account".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/address_map#kind AddressMap#kind}
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kind
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAddressMapMemberships), fullyQualifiedName: "cloudflare.addressMap.AddressMapMemberships")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AddressMap.IAddressMapMemberships
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The identifier for the membership (eg. a zone or account tag).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/address_map#identifier AddressMap#identifier}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Identifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The type of the membership. Available values: "zone", "account".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/address_map#kind AddressMap#kind}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kind
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
