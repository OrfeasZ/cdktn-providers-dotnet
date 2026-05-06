using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPolicies")]
    public class ApigatewayDeploymentSpecificationRoutesRequestPolicies : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPolicies
    {
        /// <summary>authorization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#authorization ApigatewayDeployment#authorization}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authorization", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesAuthorization\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesAuthorization? Authorization
        {
            get;
            set;
        }

        /// <summary>body_validation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#body_validation ApigatewayDeployment#body_validation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bodyValidation", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidation\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidation? BodyValidation
        {
            get;
            set;
        }

        /// <summary>cors block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#cors ApigatewayDeployment#cors}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesCors\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesCors? Cors
        {
            get;
            set;
        }

        /// <summary>header_transformations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#header_transformations ApigatewayDeployment#header_transformations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerTransformations", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformations\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformations? HeaderTransformations
        {
            get;
            set;
        }

        /// <summary>header_validations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#header_validations ApigatewayDeployment#header_validations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerValidations", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderValidations\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderValidations? HeaderValidations
        {
            get;
            set;
        }

        /// <summary>query_parameter_transformations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#query_parameter_transformations ApigatewayDeployment#query_parameter_transformations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryParameterTransformations", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformations\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformations? QueryParameterTransformations
        {
            get;
            set;
        }

        /// <summary>query_parameter_validations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#query_parameter_validations ApigatewayDeployment#query_parameter_validations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryParameterValidations", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterValidations\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterValidations? QueryParameterValidations
        {
            get;
            set;
        }

        /// <summary>response_cache_lookup block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#response_cache_lookup ApigatewayDeployment#response_cache_lookup}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseCacheLookup", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesResponseCacheLookup\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesResponseCacheLookup? ResponseCacheLookup
        {
            get;
            set;
        }
    }
}
