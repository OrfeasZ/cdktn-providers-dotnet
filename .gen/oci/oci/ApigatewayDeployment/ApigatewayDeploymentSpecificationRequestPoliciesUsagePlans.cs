using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesUsagePlans")]
    public class ApigatewayDeploymentSpecificationRequestPoliciesUsagePlans : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesUsagePlans
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#token_locations ApigatewayDeployment#token_locations}.</summary>
        [JsiiProperty(name: "tokenLocations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] TokenLocations
        {
            get;
            set;
        }
    }
}
