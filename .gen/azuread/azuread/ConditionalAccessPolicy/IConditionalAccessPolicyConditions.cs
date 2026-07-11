using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ConditionalAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IConditionalAccessPolicyConditions), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditions")]
    public interface IConditionalAccessPolicyConditions
    {
        /// <summary>applications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#applications ConditionalAccessPolicy#applications}
        /// </remarks>
        [JsiiProperty(name: "applications", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplications\"}")]
        azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplications Applications
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#client_app_types ConditionalAccessPolicy#client_app_types}.</summary>
        [JsiiProperty(name: "clientAppTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ClientAppTypes
        {
            get;
        }

        /// <summary>users block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#users ConditionalAccessPolicy#users}
        /// </remarks>
        [JsiiProperty(name: "users", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsers\"}")]
        azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsers Users
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#authentication_flow_transfer_methods ConditionalAccessPolicy#authentication_flow_transfer_methods}.</summary>
        [JsiiProperty(name: "authenticationFlowTransferMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AuthenticationFlowTransferMethods
        {
            get
            {
                return null;
            }
        }

        /// <summary>client_applications block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#client_applications ConditionalAccessPolicy#client_applications}
        /// </remarks>
        [JsiiProperty(name: "clientApplications", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplications\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplications? ClientApplications
        {
            get
            {
                return null;
            }
        }

        /// <summary>devices block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#devices ConditionalAccessPolicy#devices}
        /// </remarks>
        [JsiiProperty(name: "devices", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevices\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevices? Devices
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#insider_risk_levels ConditionalAccessPolicy#insider_risk_levels}.</summary>
        [JsiiProperty(name: "insiderRiskLevels", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InsiderRiskLevels
        {
            get
            {
                return null;
            }
        }

        /// <summary>locations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#locations ConditionalAccessPolicy#locations}
        /// </remarks>
        [JsiiProperty(name: "locations", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsLocations\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsLocations? Locations
        {
            get
            {
                return null;
            }
        }

        /// <summary>platforms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#platforms ConditionalAccessPolicy#platforms}
        /// </remarks>
        [JsiiProperty(name: "platforms", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsPlatforms\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsPlatforms? Platforms
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#service_principal_risk_levels ConditionalAccessPolicy#service_principal_risk_levels}.</summary>
        [JsiiProperty(name: "servicePrincipalRiskLevels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ServicePrincipalRiskLevels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_risk_levels ConditionalAccessPolicy#sign_in_risk_levels}.</summary>
        [JsiiProperty(name: "signInRiskLevels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SignInRiskLevels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#user_risk_levels ConditionalAccessPolicy#user_risk_levels}.</summary>
        [JsiiProperty(name: "userRiskLevels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? UserRiskLevels
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConditionalAccessPolicyConditions), fullyQualifiedName: "azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditions")]
        internal sealed class _Proxy : DeputyBase, azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>applications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#applications ConditionalAccessPolicy#applications}
            /// </remarks>
            [JsiiProperty(name: "applications", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsApplications\"}")]
            public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplications Applications
            {
                get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsApplications>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#client_app_types ConditionalAccessPolicy#client_app_types}.</summary>
            [JsiiProperty(name: "clientAppTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ClientAppTypes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>users block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#users ConditionalAccessPolicy#users}
            /// </remarks>
            [JsiiProperty(name: "users", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsUsers\"}")]
            public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsers Users
            {
                get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsUsers>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#authentication_flow_transfer_methods ConditionalAccessPolicy#authentication_flow_transfer_methods}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationFlowTransferMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AuthenticationFlowTransferMethods
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>client_applications block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#client_applications ConditionalAccessPolicy#client_applications}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientApplications", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsClientApplications\"}", isOptional: true)]
            public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplications? ClientApplications
            {
                get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsClientApplications?>();
            }

            /// <summary>devices block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#devices ConditionalAccessPolicy#devices}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "devices", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsDevices\"}", isOptional: true)]
            public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevices? Devices
            {
                get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsDevices?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#insider_risk_levels ConditionalAccessPolicy#insider_risk_levels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "insiderRiskLevels", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InsiderRiskLevels
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>locations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#locations ConditionalAccessPolicy#locations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "locations", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsLocations\"}", isOptional: true)]
            public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsLocations? Locations
            {
                get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsLocations?>();
            }

            /// <summary>platforms block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#platforms ConditionalAccessPolicy#platforms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "platforms", typeJson: "{\"fqn\":\"azuread.conditionalAccessPolicy.ConditionalAccessPolicyConditionsPlatforms\"}", isOptional: true)]
            public azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsPlatforms? Platforms
            {
                get => GetInstanceProperty<azuread.ConditionalAccessPolicy.IConditionalAccessPolicyConditionsPlatforms?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#service_principal_risk_levels ConditionalAccessPolicy#service_principal_risk_levels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "servicePrincipalRiskLevels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ServicePrincipalRiskLevels
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#sign_in_risk_levels ConditionalAccessPolicy#sign_in_risk_levels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signInRiskLevels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SignInRiskLevels
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/conditional_access_policy#user_risk_levels ConditionalAccessPolicy#user_risk_levels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userRiskLevels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? UserRiskLevels
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
