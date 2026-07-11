using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.GroupRoleManagementPolicy
{
    [JsiiInterface(nativeType: typeof(IGroupRoleManagementPolicyEligibleAssignmentRules), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyEligibleAssignmentRules")]
    public interface IGroupRoleManagementPolicyEligibleAssignmentRules
    {
        /// <summary>Must the assignment have an expiry date.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#expiration_required GroupRoleManagementPolicy#expiration_required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "expirationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExpirationRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>The duration after which assignments expire.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#expire_after GroupRoleManagementPolicy#expire_after}
        /// </remarks>
        [JsiiProperty(name: "expireAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpireAfter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGroupRoleManagementPolicyEligibleAssignmentRules), fullyQualifiedName: "azuread.groupRoleManagementPolicy.GroupRoleManagementPolicyEligibleAssignmentRules")]
        internal sealed class _Proxy : DeputyBase, azuread.GroupRoleManagementPolicy.IGroupRoleManagementPolicyEligibleAssignmentRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Must the assignment have an expiry date.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#expiration_required GroupRoleManagementPolicy#expiration_required}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expirationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExpirationRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The duration after which assignments expire.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/group_role_management_policy#expire_after GroupRoleManagementPolicy#expire_after}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expireAfter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpireAfter
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
