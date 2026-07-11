using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IConditionalAccessPolicyConditionsApplications), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplications")]
    public interface IConditionalAccessPolicyConditionsApplications
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_applications ConditionalAccessPolicy#excluded_applications}.</summary>
        [JsiiProperty(name: "excludedApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedApplications
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#filter ConditionalAccessPolicy#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplicationsFilter? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_applications ConditionalAccessPolicy#included_applications}.</summary>
        [JsiiProperty(name: "includedApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludedApplications
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_user_actions ConditionalAccessPolicy#included_user_actions}.</summary>
        [JsiiProperty(name: "includedUserActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludedUserActions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConditionalAccessPolicyConditionsApplications), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplications")]
        internal sealed class _Proxy : DeputyBase, azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_applications ConditionalAccessPolicy#excluded_applications}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedApplications
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#filter ConditionalAccessPolicy#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplicationsFilter\"}", isOptional: true)]
            public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplicationsFilter? Filter
            {
                get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplicationsFilter?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_applications ConditionalAccessPolicy#included_applications}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includedApplications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludedApplications
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_user_actions ConditionalAccessPolicy#included_user_actions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includedUserActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludedUserActions
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
