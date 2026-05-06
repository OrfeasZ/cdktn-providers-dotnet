using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser
    {
        /// <summary>self_registration_profile block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#self_registration_profile IdentityDomainsUser#self_registration_profile}
        /// </remarks>
        [JsiiProperty(name: "selfRegistrationProfile", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUserSelfRegistrationProfile\"}")]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUserSelfRegistrationProfile SelfRegistrationProfile
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#consent_granted IdentityDomainsUser#consent_granted}.</summary>
        [JsiiProperty(name: "consentGranted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ConsentGranted
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_token IdentityDomainsUser#user_token}.</summary>
        [JsiiProperty(name: "userToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>self_registration_profile block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#self_registration_profile IdentityDomainsUser#self_registration_profile}
            /// </remarks>
            [JsiiProperty(name: "selfRegistrationProfile", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUserSelfRegistrationProfile\"}")]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUserSelfRegistrationProfile SelfRegistrationProfile
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionselfRegistrationUserSelfRegistrationProfile>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#consent_granted IdentityDomainsUser#consent_granted}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "consentGranted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ConsentGranted
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#user_token IdentityDomainsUser#user_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserToken
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
