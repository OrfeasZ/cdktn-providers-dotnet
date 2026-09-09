using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AccountaccessEntitlement
{
    [JsiiByValue(fqn: "aws.accountaccessEntitlement.AccountaccessEntitlementEntitlementPrincipalRolePrincipalIdentityCenter")]
    public class AccountaccessEntitlementEntitlementPrincipalRolePrincipalIdentityCenter : aws.AccountaccessEntitlement.IAccountaccessEntitlementEntitlementPrincipalRolePrincipalIdentityCenter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#group_id AccountaccessEntitlement#group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/accountaccess_entitlement#user_id AccountaccessEntitlement#user_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserId
        {
            get;
            set;
        }
    }
}
