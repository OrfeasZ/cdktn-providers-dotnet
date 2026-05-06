using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthenticationFactorSetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettings), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettings")]
    public interface IIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettings
    {
        /// <summary>duo_security_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#duo_security_settings IdentityDomainsAuthenticationFactorSetting#duo_security_settings}
        /// </remarks>
        [JsiiProperty(name: "duoSecuritySettings", typeJson: "{\"fqn\":\"oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettingsDuoSecuritySettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettingsDuoSecuritySettings? DuoSecuritySettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettings), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettings")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>duo_security_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#duo_security_settings IdentityDomainsAuthenticationFactorSetting#duo_security_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "duoSecuritySettings", typeJson: "{\"fqn\":\"oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettingsDuoSecuritySettings\"}", isOptional: true)]
            public oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettingsDuoSecuritySettings? DuoSecuritySettings
            {
                get => GetInstanceProperty<oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingUrnietfparamsscimschemasoracleidcsextensionthirdPartyAuthenticationFactorSettingsDuoSecuritySettings?>();
            }
        }
    }
}
