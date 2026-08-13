using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorCustomDomain
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorCustomDomainTls), fullyQualifiedName: "azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTls")]
    public interface ICdnFrontdoorCustomDomainTls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_custom_domain#cdn_frontdoor_secret_id CdnFrontdoorCustomDomain#cdn_frontdoor_secret_id}.</summary>
        [JsiiProperty(name: "cdnFrontdoorSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CdnFrontdoorSecretId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_custom_domain#certificate_type CdnFrontdoorCustomDomain#certificate_type}.</summary>
        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateType
        {
            get
            {
                return null;
            }
        }

        /// <summary>cipher_suite block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_custom_domain#cipher_suite CdnFrontdoorCustomDomain#cipher_suite}
        /// </remarks>
        [JsiiProperty(name: "cipherSuite", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTlsCipherSuite\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTlsCipherSuite? CipherSuite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_custom_domain#minimum_version CdnFrontdoorCustomDomain#minimum_version}.</summary>
        [JsiiProperty(name: "minimumVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinimumVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorCustomDomainTls), fullyQualifiedName: "azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTls")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_custom_domain#cdn_frontdoor_secret_id CdnFrontdoorCustomDomain#cdn_frontdoor_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cdnFrontdoorSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CdnFrontdoorSecretId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_custom_domain#certificate_type CdnFrontdoorCustomDomain#certificate_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>cipher_suite block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_custom_domain#cipher_suite CdnFrontdoorCustomDomain#cipher_suite}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cipherSuite", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTlsCipherSuite\"}", isOptional: true)]
            public azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTlsCipherSuite? CipherSuite
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTlsCipherSuite?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/cdn_frontdoor_custom_domain#minimum_version CdnFrontdoorCustomDomain#minimum_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinimumVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
