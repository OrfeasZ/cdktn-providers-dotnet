using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayUsagePlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsQuota")]
    public class ApigatewayUsagePlanEntitlementsQuota : oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsQuota
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#operation_on_breach ApigatewayUsagePlan#operation_on_breach}.</summary>
        [JsiiProperty(name: "operationOnBreach", typeJson: "{\"primitive\":\"string\"}")]
        public string OperationOnBreach
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#reset_policy ApigatewayUsagePlan#reset_policy}.</summary>
        [JsiiProperty(name: "resetPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public string ResetPolicy
        {
            get;
            set;
        }

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
