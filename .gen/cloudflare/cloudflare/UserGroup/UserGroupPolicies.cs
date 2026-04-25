using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.UserGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.userGroup.UserGroupPolicies")]
    public class UserGroupPolicies : cloudflare.UserGroup.IUserGroupPolicies
    {
        /// <summary>Allow or deny operations against the resources. Available values: "allow", "deny".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_group#access UserGroup#access}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_group#permission_groups UserGroup#permission_groups}
        /// </remarks>
        [JsiiProperty(name: "permissionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.userGroup.UserGroupPoliciesPermissionGroups\"},\"kind\":\"array\"}}]}}")]
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
                        case cloudflare.UserGroup.IUserGroupPoliciesPermissionGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.UserGroup.IUserGroupPoliciesPermissionGroups).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.UserGroup.IUserGroupPoliciesPermissionGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _permissionGroups = value;
            }
        }

        private object _resourceGroups;

        /// <summary>A set of resource groups that are specified to the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/user_group#resource_groups UserGroup#resource_groups}
        /// </remarks>
        [JsiiProperty(name: "resourceGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.userGroup.UserGroupPoliciesResourceGroups\"},\"kind\":\"array\"}}]}}")]
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
                        case cloudflare.UserGroup.IUserGroupPoliciesResourceGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.UserGroup.IUserGroupPoliciesResourceGroups).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.UserGroup.IUserGroupPoliciesResourceGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceGroups = value;
            }
        }
    }
}
