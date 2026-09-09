using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAccountaccessEntitlements
{
    [JsiiInterface(nativeType: typeof(IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter), fullyQualifiedName: "aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter")]
    public interface IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/data-sources/accountaccess_entitlements#group_id DataAwsAccountaccessEntitlements#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/data-sources/accountaccess_entitlements#user_id DataAwsAccountaccessEntitlements#user_id}.</summary>
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter), fullyQualifiedName: "aws.dataAwsAccountaccessEntitlements.DataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsAccountaccessEntitlements.IDataAwsAccountaccessEntitlementsFilterPrincipalRolePrincipalIdentityCenter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/data-sources/accountaccess_entitlements#group_id DataAwsAccountaccessEntitlements#group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/data-sources/accountaccess_entitlements#user_id DataAwsAccountaccessEntitlements#user_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
