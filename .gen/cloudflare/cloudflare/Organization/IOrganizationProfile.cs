using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Organization
{
    [JsiiInterface(nativeType: typeof(IOrganizationProfile), fullyQualifiedName: "cloudflare.organization.OrganizationProfile")]
    public interface IOrganizationProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization#business_address Organization#business_address}.</summary>
        [JsiiProperty(name: "businessAddress", typeJson: "{\"primitive\":\"string\"}")]
        string BusinessAddress
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization#business_email Organization#business_email}.</summary>
        [JsiiProperty(name: "businessEmail", typeJson: "{\"primitive\":\"string\"}")]
        string BusinessEmail
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization#business_name Organization#business_name}.</summary>
        [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}")]
        string BusinessName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization#business_phone Organization#business_phone}.</summary>
        [JsiiProperty(name: "businessPhone", typeJson: "{\"primitive\":\"string\"}")]
        string BusinessPhone
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization#external_metadata Organization#external_metadata}.</summary>
        [JsiiProperty(name: "externalMetadata", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalMetadata
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOrganizationProfile), fullyQualifiedName: "cloudflare.organization.OrganizationProfile")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Organization.IOrganizationProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization#business_address Organization#business_address}.</summary>
            [JsiiProperty(name: "businessAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string BusinessAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization#business_email Organization#business_email}.</summary>
            [JsiiProperty(name: "businessEmail", typeJson: "{\"primitive\":\"string\"}")]
            public string BusinessEmail
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization#business_name Organization#business_name}.</summary>
            [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}")]
            public string BusinessName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization#business_phone Organization#business_phone}.</summary>
            [JsiiProperty(name: "businessPhone", typeJson: "{\"primitive\":\"string\"}")]
            public string BusinessPhone
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization#external_metadata Organization#external_metadata}.</summary>
            [JsiiProperty(name: "externalMetadata", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalMetadata
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
