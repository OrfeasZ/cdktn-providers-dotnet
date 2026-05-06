using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGroup
{
    [JsiiByValue(fqn: "oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroup")]
    public class IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroup : oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_group#membership_rule IdentityDomainsGroup#membership_rule}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "membershipRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MembershipRule
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_group#membership_type IdentityDomainsGroup#membership_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "membershipType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MembershipType
        {
            get;
            set;
        }
    }
}
