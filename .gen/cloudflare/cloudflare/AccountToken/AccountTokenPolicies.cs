using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountToken
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.accountToken.AccountTokenPolicies")]
    public class AccountTokenPolicies : cloudflare.AccountToken.IAccountTokenPolicies
    {
        /// <summary>Allow or deny operations against the resources. Available values: "allow", "deny".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_token#effect AccountToken#effect}
        /// </remarks>
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
        public string Effect
        {
            get;
            set;
        }

        private object _permissionGroups;

        /// <summary>A set of permission groups that are specified to the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_token#permission_groups AccountToken#permission_groups}
        /// </remarks>
        [JsiiProperty(name: "permissionGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.accountToken.AccountTokenPoliciesPermissionGroups\"},\"kind\":\"array\"}}]}}")]
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
                        case cloudflare.AccountToken.IAccountTokenPoliciesPermissionGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AccountToken.IAccountTokenPoliciesPermissionGroups).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.AccountToken.IAccountTokenPoliciesPermissionGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _permissionGroups = value;
            }
        }

        /// <summary>A json object representing the resources that are specified to the policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/account_token#resources AccountToken#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"primitive\":\"string\"}")]
        public string Resources
        {
            get;
            set;
        }
    }
}
