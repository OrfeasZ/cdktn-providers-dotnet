using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.UserGroup
{
    [JsiiInterface(nativeType: typeof(IUserGroupPolicies), fullyQualifiedName: "cloudflare.userGroup.UserGroupPolicies")]
    public interface IUserGroupPolicies
    {
        /// <summary>Allow or deny operations against the resources. Available values: "allow", "deny".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_group#access UserGroup#access}
        /// </remarks>
        [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}")]
        string Access
        {
            get;
        }

        /// <summary>A set of permission groups that are specified to the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_group#permission_groups UserGroup#permission_groups}
        /// </remarks>
        [JsiiProperty(name: "permissionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.userGroup.UserGroupPoliciesPermissionGroups\"},\"kind\":\"array\"}}]}}")]
        object PermissionGroups
        {
            get;
        }

        /// <summary>A set of resource groups that are specified to the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_group#resource_groups UserGroup#resource_groups}
        /// </remarks>
        [JsiiProperty(name: "resourceGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.userGroup.UserGroupPoliciesResourceGroups\"},\"kind\":\"array\"}}]}}")]
        object ResourceGroups
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IUserGroupPolicies), fullyQualifiedName: "cloudflare.userGroup.UserGroupPolicies")]
        internal sealed class _Proxy : DeputyBase, cloudflare.UserGroup.IUserGroupPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Allow or deny operations against the resources. Available values: "allow", "deny".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_group#access UserGroup#access}
            /// </remarks>
            [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}")]
            public string Access
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A set of permission groups that are specified to the policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_group#permission_groups UserGroup#permission_groups}
            /// </remarks>
            [JsiiProperty(name: "permissionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.userGroup.UserGroupPoliciesPermissionGroups\"},\"kind\":\"array\"}}]}}")]
            public object PermissionGroups
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>A set of resource groups that are specified to the policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_group#resource_groups UserGroup#resource_groups}
            /// </remarks>
            [JsiiProperty(name: "resourceGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.userGroup.UserGroupPoliciesResourceGroups\"},\"kind\":\"array\"}}]}}")]
            public object ResourceGroups
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
