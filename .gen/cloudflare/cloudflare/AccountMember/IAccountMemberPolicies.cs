using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountMember
{
    [JsiiInterface(nativeType: typeof(IAccountMemberPolicies), fullyQualifiedName: "cloudflare.accountMember.AccountMemberPolicies")]
    public interface IAccountMemberPolicies
    {
        /// <summary>Allow or deny operations against the resources. Available values: "allow", "deny".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_member#access AccountMember#access}
        /// </remarks>
        [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}")]
        string Access
        {
            get;
        }

        /// <summary>A set of permission groups that are specified to the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_member#permission_groups AccountMember#permission_groups}
        /// </remarks>
        [JsiiProperty(name: "permissionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.accountMember.AccountMemberPoliciesPermissionGroups\"},\"kind\":\"array\"}}]}}")]
        object PermissionGroups
        {
            get;
        }

        /// <summary>A list of resource groups that the policy applies to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_member#resource_groups AccountMember#resource_groups}
        /// </remarks>
        [JsiiProperty(name: "resourceGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.accountMember.AccountMemberPoliciesResourceGroups\"},\"kind\":\"array\"}}]}}")]
        object ResourceGroups
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountMemberPolicies), fullyQualifiedName: "cloudflare.accountMember.AccountMemberPolicies")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccountMember.IAccountMemberPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Allow or deny operations against the resources. Available values: "allow", "deny".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_member#access AccountMember#access}
            /// </remarks>
            [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}")]
            public string Access
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A set of permission groups that are specified to the policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_member#permission_groups AccountMember#permission_groups}
            /// </remarks>
            [JsiiProperty(name: "permissionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.accountMember.AccountMemberPoliciesPermissionGroups\"},\"kind\":\"array\"}}]}}")]
            public object PermissionGroups
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>A list of resource groups that the policy applies to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/account_member#resource_groups AccountMember#resource_groups}
            /// </remarks>
            [JsiiProperty(name: "resourceGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.accountMember.AccountMemberPoliciesResourceGroups\"},\"kind\":\"array\"}}]}}")]
            public object ResourceGroups
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
