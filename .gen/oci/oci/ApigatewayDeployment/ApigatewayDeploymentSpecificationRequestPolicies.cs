using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPolicies")]
    public class ApigatewayDeploymentSpecificationRequestPolicies : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPolicies
    {
        /// <summary>authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#authentication ApigatewayDeployment#authentication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthentication\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthentication? Authentication
        {
            get;
            set;
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#cors ApigatewayDeployment#cors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesCors\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesCors? Cors
        {
            get;
            set;
        }

        /// <summary>dynamic_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#dynamic_authentication ApigatewayDeployment#dynamic_authentication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dynamicAuthentication", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthentication\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthentication? DynamicAuthentication
        {
            get;
            set;
        }

        /// <summary>mutual_tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#mutual_tls ApigatewayDeployment#mutual_tls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mutualTls", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesMutualTls\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesMutualTls? MutualTls
        {
            get;
            set;
        }

        /// <summary>rate_limiting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#rate_limiting ApigatewayDeployment#rate_limiting}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rateLimiting", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesRateLimiting\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesRateLimiting? RateLimiting
        {
            get;
            set;
        }

        /// <summary>usage_plans block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#usage_plans ApigatewayDeployment#usage_plans}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usagePlans", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesUsagePlans\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesUsagePlans? UsagePlans
        {
            get;
            set;
        }
    }
}
