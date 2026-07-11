using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IConditionalAccessPolicyConditionsUsers), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsers")]
    public interface IConditionalAccessPolicyConditionsUsers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_groups ConditionalAccessPolicy#excluded_groups}.</summary>
        [JsiiProperty(name: "excludedGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>excluded_guests_or_external_users block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_guests_or_external_users ConditionalAccessPolicy#excluded_guests_or_external_users}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsers" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "excludedGuestsOrExternalUsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludedGuestsOrExternalUsers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_roles ConditionalAccessPolicy#excluded_roles}.</summary>
        [JsiiProperty(name: "excludedRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedRoles
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_users ConditionalAccessPolicy#excluded_users}.</summary>
        [JsiiProperty(name: "excludedUsers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedUsers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_groups ConditionalAccessPolicy#included_groups}.</summary>
        [JsiiProperty(name: "includedGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludedGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>included_guests_or_external_users block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_guests_or_external_users ConditionalAccessPolicy#included_guests_or_external_users}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "includedGuestsOrExternalUsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludedGuestsOrExternalUsers
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_roles ConditionalAccessPolicy#included_roles}.</summary>
        [JsiiProperty(name: "includedRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludedRoles
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_users ConditionalAccessPolicy#included_users}.</summary>
        [JsiiProperty(name: "includedUsers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludedUsers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConditionalAccessPolicyConditionsUsers), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsers")]
        internal sealed class _Proxy : DeputyBase, azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_groups ConditionalAccessPolicy#excluded_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>excluded_guests_or_external_users block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_guests_or_external_users ConditionalAccessPolicy#excluded_guests_or_external_users}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsers" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludedGuestsOrExternalUsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersExcludedGuestsOrExternalUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExcludedGuestsOrExternalUsers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_roles ConditionalAccessPolicy#excluded_roles}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedRoles
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_users ConditionalAccessPolicy#excluded_users}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedUsers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedUsers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_groups ConditionalAccessPolicy#included_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includedGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludedGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>included_guests_or_external_users block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_guests_or_external_users ConditionalAccessPolicy#included_guests_or_external_users}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includedGuestsOrExternalUsers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsersIncludedGuestsOrExternalUsers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IncludedGuestsOrExternalUsers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_roles ConditionalAccessPolicy#included_roles}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includedRoles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludedRoles
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_users ConditionalAccessPolicy#included_users}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includedUsers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludedUsers
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
