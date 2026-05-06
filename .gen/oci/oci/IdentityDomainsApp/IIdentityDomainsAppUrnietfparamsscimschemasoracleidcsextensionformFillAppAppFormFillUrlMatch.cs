using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppFormFillUrlMatch), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppFormFillUrlMatch")]
    public interface IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppFormFillUrlMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_url IdentityDomainsApp#form_url}.</summary>
        [JsiiProperty(name: "formUrl", typeJson: "{\"primitive\":\"string\"}")]
        string FormUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_url_match_type IdentityDomainsApp#form_url_match_type}.</summary>
        [JsiiProperty(name: "formUrlMatchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FormUrlMatchType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppFormFillUrlMatch), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppFormFillUrlMatch")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppFormFillUrlMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_url IdentityDomainsApp#form_url}.</summary>
            [JsiiProperty(name: "formUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string FormUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_url_match_type IdentityDomainsApp#form_url_match_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "formUrlMatchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FormUrlMatchType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
