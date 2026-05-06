using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential")]
    public interface IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#access_token IdentityDomainsApp#access_token}.</summary>
        [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#access_token_expiry IdentityDomainsApp#access_token_expiry}.</summary>
        [JsiiProperty(name: "accessTokenExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessTokenExpiry
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#refresh_token IdentityDomainsApp#refresh_token}.</summary>
        [JsiiProperty(name: "refreshToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RefreshToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppThreeLeggedOauthCredential
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#access_token IdentityDomainsApp#access_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessToken
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#access_token_expiry IdentityDomainsApp#access_token_expiry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessTokenExpiry", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessTokenExpiry
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#refresh_token IdentityDomainsApp#refresh_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "refreshToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RefreshToken
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
