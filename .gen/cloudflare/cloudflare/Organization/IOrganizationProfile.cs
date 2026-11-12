using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Organization
{
    [JsiiInterface(nativeType: typeof(IOrganizationProfile), fullyQualifiedName: "cloudflare.organization.OrganizationProfile")]
    public interface IOrganizationProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#business_address Organization#business_address}.</summary>
        [JsiiProperty(name: "businessAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BusinessAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#business_email Organization#business_email}.</summary>
        [JsiiProperty(name: "businessEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BusinessEmail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#business_name Organization#business_name}.</summary>
        [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BusinessName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#business_phone Organization#business_phone}.</summary>
        [JsiiProperty(name: "businessPhone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BusinessPhone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#external_metadata Organization#external_metadata}.</summary>
        [JsiiProperty(name: "externalMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalMetadata
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOrganizationProfile), fullyQualifiedName: "cloudflare.organization.OrganizationProfile")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Organization.IOrganizationProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#business_address Organization#business_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "businessAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BusinessAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#business_email Organization#business_email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "businessEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BusinessEmail
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#business_name Organization#business_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BusinessName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#business_phone Organization#business_phone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "businessPhone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BusinessPhone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.29.0/docs/resources/organization#external_metadata Organization#external_metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalMetadata", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalMetadata
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
