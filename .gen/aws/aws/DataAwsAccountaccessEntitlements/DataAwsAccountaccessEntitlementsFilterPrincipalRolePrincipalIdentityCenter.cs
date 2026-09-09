using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAccountaccessEntitlements
{
    [JsiiByValue(fqn: "aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter")]
    public class DataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter : aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/data-sources/accountaccess_entitlements#group_id DataAwsAccountaccessEntitlements#group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/data-sources/accountaccess_entitlements#user_id DataAwsAccountaccessEntitlements#user_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserId
        {
            get;
            set;
        }
    }
}
