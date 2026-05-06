using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformations")]
    public class ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformations : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformations
    {
        /// <summary>filter_query_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#filter_query_parameters ApigatewayDeployment#filter_query_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterQueryParameters", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParameters\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParameters? FilterQueryParameters
        {
            get;
            set;
        }

        /// <summary>rename_query_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#rename_query_parameters ApigatewayDeployment#rename_query_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "renameQueryParameters", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsRenameQueryParameters\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsRenameQueryParameters? RenameQueryParameters
        {
            get;
            set;
        }

        /// <summary>set_query_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#set_query_parameters ApigatewayDeployment#set_query_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setQueryParameters", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsSetQueryParameters\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsSetQueryParameters? SetQueryParameters
        {
            get;
            set;
        }
    }
}
