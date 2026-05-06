using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayUsagePlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsRateLimit")]
    public class ApigatewayUsagePlanEntitlementsRateLimit : oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsRateLimit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#unit ApigatewayUsagePlan#unit}.</summary>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        public string Unit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#value ApigatewayUsagePlan#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }
    }
}
