using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidationContent")]
    public class ApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidationContent : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidationContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#media_type ApigatewayDeployment#media_type}.</summary>
        [JsiiProperty(name: "mediaType", typeJson: "{\"primitive\":\"string\"}")]
        public string MediaType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#validation_type ApigatewayDeployment#validation_type}.</summary>
        [JsiiProperty(name: "validationType", typeJson: "{\"primitive\":\"string\"}")]
        public string ValidationType
        {
            get;
            set;
        }
    }
}
