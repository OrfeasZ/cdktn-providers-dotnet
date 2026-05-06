using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppFormFillUrlMatch")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppFormFillUrlMatch : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppFormFillUrlMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_url IdentityDomainsApp#form_url}.</summary>
        [JsiiProperty(name: "formUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string FormUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_url_match_type IdentityDomainsApp#form_url_match_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "formUrlMatchType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FormUrlMatchType
        {
            get;
            set;
        }
    }
}
