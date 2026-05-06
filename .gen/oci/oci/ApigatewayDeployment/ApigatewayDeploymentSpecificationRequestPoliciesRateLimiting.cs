using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesRateLimiting")]
    public class ApigatewayDeploymentSpecificationRequestPoliciesRateLimiting : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesRateLimiting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#rate_in_requests_per_second ApigatewayDeployment#rate_in_requests_per_second}.</summary>
        [JsiiProperty(name: "rateInRequestsPerSecond", typeJson: "{\"primitive\":\"number\"}")]
        public double RateInRequestsPerSecond
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#rate_key ApigatewayDeployment#rate_key}.</summary>
        [JsiiProperty(name: "rateKey", typeJson: "{\"primitive\":\"string\"}")]
        public string RateKey
        {
            get;
            set;
        }
    }
}
