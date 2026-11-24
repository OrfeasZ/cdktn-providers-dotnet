using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappAccount
{
    [JsiiByValue(fqn: "azurerm.netappAccount.NetappAccountActiveDirectoryLdapSearchScope")]
    public class NetappAccountActiveDirectoryLdapSearchScope : azurerm.NetappAccount.INetappAccountActiveDirectoryLdapSearchScope
    {
        /// <summary>The group DN, which overrides the base DN for group lookups.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/netapp_account#group_dn NetappAccount#group_dn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupDn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupDn
        {
            get;
            set;
        }

        /// <summary>The custom LDAP search filter to be used when looking up group membership from LDAP server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/netapp_account#group_membership_filter NetappAccount#group_membership_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupMembershipFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupMembershipFilter
        {
            get;
            set;
        }

        /// <summary>The user DN, which overrides the base DN for user lookups.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/netapp_account#user_dn NetappAccount#user_dn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userDn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserDn
        {
            get;
            set;
        }
    }
}
