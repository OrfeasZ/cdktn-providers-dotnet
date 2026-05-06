using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthenticationFactorSetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAuthenticationFactorSettingThirdPartyFactor), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingThirdPartyFactor")]
    public interface IIdentityDomainsAuthenticationFactorSettingThirdPartyFactor
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#duo_security IdentityDomainsAuthenticationFactorSetting#duo_security}.</summary>
        [JsiiProperty(name: "duoSecurity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object DuoSecurity
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAuthenticationFactorSettingThirdPartyFactor), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingThirdPartyFactor")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingThirdPartyFactor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#duo_security IdentityDomainsAuthenticationFactorSetting#duo_security}.</summary>
            [JsiiProperty(name: "duoSecurity", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object DuoSecurity
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
