using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesLoggingPolicies")]
    public class ApigatewayDeploymentSpecificationRoutesLoggingPolicies : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesLoggingPolicies
    {
        /// <summary>access_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#access_log ApigatewayDeployment#access_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesLoggingPoliciesAccessLog\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesLoggingPoliciesAccessLog? AccessLog
        {
            get;
            set;
        }

        /// <summary>execution_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#execution_log ApigatewayDeployment#execution_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "executionLog", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog? ExecutionLog
        {
            get;
            set;
        }
    }
}
