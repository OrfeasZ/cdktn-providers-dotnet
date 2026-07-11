using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiByValue(fqn: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsers")]
    public class ConditionalAccessPolicyConditionsUsers : azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_groups ConditionalAccessPolicy#excluded_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedGroups
        {
            get;
            set;
        }

        private object? _excludedGuestsOrExternalUsers;

        /// <summary>excluded_guests_or_external_users block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_guests_or_external_users ConditionalAccessPolicy#excluded_guests_or_external_users}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsers" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludedGuestsOrExternalUsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExcludedGuestsOrExternalUsers
        {
            get => _excludedGuestsOrExternalUsers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _excludedGuestsOrExternalUsers = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_roles ConditionalAccessPolicy#excluded_roles}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedRoles
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_users ConditionalAccessPolicy#excluded_users}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedUsers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedUsers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_groups ConditionalAccessPolicy#included_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includedGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludedGroups
        {
            get;
            set;
        }

        private object? _includedGuestsOrExternalUsers;

        /// <summary>included_guests_or_external_users block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_guests_or_external_users ConditionalAccessPolicy#included_guests_or_external_users}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includedGuestsOrExternalUsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IncludedGuestsOrExternalUsers
        {
            get => _includedGuestsOrExternalUsers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _includedGuestsOrExternalUsers = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_roles ConditionalAccessPolicy#included_roles}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includedRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludedRoles
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_users ConditionalAccessPolicy#included_users}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includedUsers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludedUsers
        {
            get;
            set;
        }
    }
}
