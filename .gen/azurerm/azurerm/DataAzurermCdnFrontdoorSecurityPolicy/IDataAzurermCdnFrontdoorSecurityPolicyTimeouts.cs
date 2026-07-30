using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCdnFrontdoorSecurityPolicy
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCdnFrontdoorSecurityPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorSecurityPolicy.DataAzurermCdnFrontdoorSecurityPolicyTimeouts")]
    public interface IDataAzurermCdnFrontdoorSecurityPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/cdn_frontdoor_security_policy#read DataAzurermCdnFrontdoorSecurityPolicy#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCdnFrontdoorSecurityPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorSecurityPolicy.DataAzurermCdnFrontdoorSecurityPolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCdnFrontdoorSecurityPolicy.IDataAzurermCdnFrontdoorSecurityPolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/data-sources/cdn_frontdoor_security_policy#read DataAzurermCdnFrontdoorSecurityPolicy#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
