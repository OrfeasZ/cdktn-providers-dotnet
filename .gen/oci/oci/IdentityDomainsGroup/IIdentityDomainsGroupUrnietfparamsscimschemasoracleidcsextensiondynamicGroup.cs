using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsGroup
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroup), fullyQualifiedName: "oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroup")]
    public interface IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_group#membership_rule IdentityDomainsGroup#membership_rule}.</summary>
        [JsiiProperty(name: "membershipRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MembershipRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_group#membership_type IdentityDomainsGroup#membership_type}.</summary>
        [JsiiProperty(name: "membershipType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MembershipType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroup), fullyQualifiedName: "oci.identityDomainsGroup.IdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroup")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsGroup.IIdentityDomainsGroupUrnietfparamsscimschemasoracleidcsextensiondynamicGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_group#membership_rule IdentityDomainsGroup#membership_rule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "membershipRule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MembershipRule
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_group#membership_type IdentityDomainsGroup#membership_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "membershipType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MembershipType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
