using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IConditionalAccessPolicyConditionsClientApplications), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplications")]
    public interface IConditionalAccessPolicyConditionsClientApplications
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_service_principals ConditionalAccessPolicy#excluded_service_principals}.</summary>
        [JsiiProperty(name: "excludedServicePrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedServicePrincipals
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
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplicationsFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplicationsFilter? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_service_principals ConditionalAccessPolicy#included_service_principals}.</summary>
        [JsiiProperty(name: "includedServicePrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludedServicePrincipals
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConditionalAccessPolicyConditionsClientApplications), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplications")]
        internal sealed class _Proxy : DeputyBase, azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplications
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#excluded_service_principals ConditionalAccessPolicy#excluded_service_principals}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedServicePrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedServicePrincipals
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#filter ConditionalAccessPolicy#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplicationsFilter\"}", isOptional: true)]
            public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplicationsFilter? Filter
            {
                get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplicationsFilter?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#included_service_principals ConditionalAccessPolicy#included_service_principals}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includedServicePrincipals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludedServicePrincipals
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
