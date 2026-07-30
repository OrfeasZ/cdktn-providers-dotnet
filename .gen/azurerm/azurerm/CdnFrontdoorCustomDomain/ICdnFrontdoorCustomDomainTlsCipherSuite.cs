using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorCustomDomain
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorCustomDomainTlsCipherSuite), fullyQualifiedName: "azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTlsCipherSuite")]
    public interface ICdnFrontdoorCustomDomainTlsCipherSuite
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_custom_domain#type CdnFrontdoorCustomDomain#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>custom_ciphers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_custom_domain#custom_ciphers CdnFrontdoorCustomDomain#custom_ciphers}
        /// </remarks>
        [JsiiProperty(name: "customCiphers", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphers\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphers? CustomCiphers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorCustomDomainTlsCipherSuite), fullyQualifiedName: "azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTlsCipherSuite")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTlsCipherSuite
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_custom_domain#type CdnFrontdoorCustomDomain#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>custom_ciphers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/cdn_frontdoor_custom_domain#custom_ciphers CdnFrontdoorCustomDomain#custom_ciphers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customCiphers", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorCustomDomain.CdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphers\"}", isOptional: true)]
            public azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphers? CustomCiphers
            {
                get => GetInstanceProperty<azurerm.CdnFrontdoorCustomDomain.ICdnFrontdoorCustomDomainTlsCipherSuiteCustomCiphers?>();
            }
        }
    }
}
