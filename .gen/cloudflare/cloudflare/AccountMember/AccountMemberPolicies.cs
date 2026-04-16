using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountMember
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.accountMember.AccountMemberPolicies")]
    public class AccountMemberPolicies : cloudflare.AccountMember.IAccountMemberPolicies
    {
        /// <summary>Allow or deny operations against the resources. Available values: "allow", "deny".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_member#access AccountMember#access}
        /// </remarks>
        [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}")]
        public string Access
        {
            get;
            set;
        }

        private object _permissionGroups;

        /// <summary>A set of permission groups that are specified to the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_member#permission_groups AccountMember#permission_groups}
        /// </remarks>
        [JsiiProperty(name: "permissionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.accountMember.AccountMemberPoliciesPermissionGroups\"},\"kind\":\"array\"}}]}}")]
        public object PermissionGroups
        {
            get => _permissionGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.AccountMember.IAccountMemberPoliciesPermissionGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AccountMember.IAccountMemberPoliciesPermissionGroups).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AccountMember.IAccountMemberPoliciesPermissionGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _permissionGroups = value;
            }
        }

        private object _resourceGroups;

        /// <summary>A list of resource groups that the policy applies to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_member#resource_groups AccountMember#resource_groups}
        /// </remarks>
        [JsiiProperty(name: "resourceGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.accountMember.AccountMemberPoliciesResourceGroups\"},\"kind\":\"array\"}}]}}")]
        public object ResourceGroups
        {
            get => _resourceGroups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.AccountMember.IAccountMemberPoliciesResourceGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AccountMember.IAccountMemberPoliciesResourceGroups).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AccountMember.IAccountMemberPoliciesResourceGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceGroups = value;
            }
        }
    }
}
