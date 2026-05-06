using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformations")]
    public class ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformations : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformations
    {
        /// <summary>filter_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#filter_headers ApigatewayDeployment#filter_headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsFilterHeaders\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsFilterHeaders? FilterHeaders
        {
            get;
            set;
        }

        /// <summary>rename_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#rename_headers ApigatewayDeployment#rename_headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "renameHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsRenameHeaders\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsRenameHeaders? RenameHeaders
        {
            get;
            set;
        }

        /// <summary>set_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#set_headers ApigatewayDeployment#set_headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsSetHeaders\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationFailurePolicyResponseHeaderTransformationsSetHeaders? SetHeaders
        {
            get;
            set;
        }
    }
}
