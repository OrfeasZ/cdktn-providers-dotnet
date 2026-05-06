using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePolicies")]
    public class ApigatewayDeploymentSpecificationRoutesResponsePolicies : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePolicies
    {
        /// <summary>header_transformations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#header_transformations ApigatewayDeployment#header_transformations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headerTransformations", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformations\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformations? HeaderTransformations
        {
            get;
            set;
        }

        /// <summary>response_cache_store block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#response_cache_store ApigatewayDeployment#response_cache_store}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseCacheStore", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesResponseCacheStore\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesResponseCacheStore? ResponseCacheStore
        {
            get;
            set;
        }
    }
}
