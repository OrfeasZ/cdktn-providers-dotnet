using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadGroupRoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IDataAzureadGroupRoleManagementPolicyTimeouts), fullyQualifiedName: "azuread.dataAzureadGroupRoleManagementPolicy.DataAzureadGroupRoleManagementPolicyTimeouts")]
    public interface IDataAzureadGroupRoleManagementPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/group_role_management_policy#read DataAzureadGroupRoleManagementPolicy#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzureadGroupRoleManagementPolicyTimeouts), fullyQualifiedName: "azuread.dataAzureadGroupRoleManagementPolicy.DataAzureadGroupRoleManagementPolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azuread.DataAzureadGroupRoleManagementPolicy.IDataAzureadGroupRoleManagementPolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/group_role_management_policy#read DataAzureadGroupRoleManagementPolicy#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
