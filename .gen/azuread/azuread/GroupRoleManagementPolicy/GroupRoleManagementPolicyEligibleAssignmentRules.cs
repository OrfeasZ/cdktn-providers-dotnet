using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiByValue(fqn: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyEligibleAssignmentRules")]
    public class GroupRoleManagementPolicyEligibleAssignmentRules : azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyEligibleAssignmentRules
    {
        private object? _expirationRequired;

        /// <summary>Must the assignment have an expiry date.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#expiration_required GroupRoleManagementPolicy#expiration_required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expirationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ExpirationRequired
        {
            get => _expirationRequired;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _expirationRequired = value;
            }
        }

        /// <summary>The duration after which assignments expire.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#expire_after GroupRoleManagementPolicy#expire_after}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expireAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExpireAfter
        {
            get;
            set;
        }
    }
}
