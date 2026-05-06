using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayUsagePlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayUsagePlan.ApigatewayUsagePlanLocks")]
    public class ApigatewayUsagePlanLocks : oci.ApigatewayUsagePlan.IApigatewayUsagePlanLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#type ApigatewayUsagePlan#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#message ApigatewayUsagePlan#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }
    }
}
