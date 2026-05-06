using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGroup
{
    [JsiiByValue(fqn: "oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionposixGroup")]
    public class IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionposixGroup : oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensionposixGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_group#gid_number IdentityDomainsGroup#gid_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gidNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GidNumber
        {
            get;
            set;
        }
    }
}
