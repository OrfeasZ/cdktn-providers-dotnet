using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesResponseCacheStore")]
    public class ApigatewayDeploymentSpecificationRoutesResponsePoliciesResponseCacheStore : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesResponseCacheStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#time_to_live_in_seconds ApigatewayDeployment#time_to_live_in_seconds}.</summary>
        [JsiiProperty(name: "timeToLiveInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double TimeToLiveInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#type ApigatewayDeployment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
