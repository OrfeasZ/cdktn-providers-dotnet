using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditions")]
    public class ConditionalAccessPolicyConditions : azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditions
    {
        /// <summary>applications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#applications ConditionalAccessPolicy#applications}
        /// </remarks>
        [JsiiProperty(name: "applications", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplications\"}")]
        public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplications Applications
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#client_app_types ConditionalAccessPolicy#client_app_types}.</summary>
        [JsiiProperty(name: "clientAppTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ClientAppTypes
        {
            get;
            set;
        }

        /// <summary>users block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#users ConditionalAccessPolicy#users}
        /// </remarks>
        [JsiiProperty(name: "users", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsers\"}")]
        public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsers Users
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#authentication_flow_transfer_methods ConditionalAccessPolicy#authentication_flow_transfer_methods}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationFlowTransferMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AuthenticationFlowTransferMethods
        {
            get;
            set;
        }

        /// <summary>client_applications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#client_applications ConditionalAccessPolicy#client_applications}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientApplications", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplications\"}", isOptional: true)]
        public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplications? ClientApplications
        {
            get;
            set;
        }

        /// <summary>devices block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#devices ConditionalAccessPolicy#devices}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "devices", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevices\"}", isOptional: true)]
        public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevices? Devices
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#insider_risk_levels ConditionalAccessPolicy#insider_risk_levels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "insiderRiskLevels", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InsiderRiskLevels
        {
            get;
            set;
        }

        /// <summary>locations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#locations ConditionalAccessPolicy#locations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "locations", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsLocations\"}", isOptional: true)]
        public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsLocations? Locations
        {
            get;
            set;
        }

        /// <summary>platforms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#platforms ConditionalAccessPolicy#platforms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "platforms", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsPlatforms\"}", isOptional: true)]
        public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsPlatforms? Platforms
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#service_principal_risk_levels ConditionalAccessPolicy#service_principal_risk_levels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "servicePrincipalRiskLevels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ServicePrincipalRiskLevels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_risk_levels ConditionalAccessPolicy#sign_in_risk_levels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signInRiskLevels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SignInRiskLevels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#user_risk_levels ConditionalAccessPolicy#user_risk_levels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userRiskLevels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? UserRiskLevels
        {
            get;
            set;
        }
    }
}
