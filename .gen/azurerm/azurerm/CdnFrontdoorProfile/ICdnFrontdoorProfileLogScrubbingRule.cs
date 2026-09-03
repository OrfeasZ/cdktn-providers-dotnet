using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorProfile
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorProfileLogScrubbingRule), fullyQualifiedName: "azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileLogScrubbingRule")]
    public interface ICdnFrontdoorProfileLogScrubbingRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_profile#match_variable CdnFrontdoorProfile#match_variable}.</summary>
        [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
        string MatchVariable
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorProfileLogScrubbingRule), fullyQualifiedName: "azurerm.cdnFrontdoorProfile.CdnFrontdoorProfileLogScrubbingRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorProfile.ICdnFrontdoorProfileLogScrubbingRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/cdn_frontdoor_profile#match_variable CdnFrontdoorProfile#match_variable}.</summary>
            [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
            public string MatchVariable
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
