using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayUsagePlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsTargets")]
    public class ApigatewayUsagePlanEntitlementsTargets : oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#deployment_id ApigatewayUsagePlan#deployment_id}.</summary>
        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public string DeploymentId
        {
            get;
            set;
        }
    }
}
