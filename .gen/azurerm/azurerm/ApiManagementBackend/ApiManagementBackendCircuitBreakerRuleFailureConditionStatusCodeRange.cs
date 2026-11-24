using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange")]
    public class ApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange : azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange
    {
        /// <summary>The maximum HTTP status code to consider as a failure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#max ApiManagementBackend#max}
        /// </remarks>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        public double Max
        {
            get;
            set;
        }

        /// <summary>The minimum HTTP status code to consider as a failure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#min ApiManagementBackend#min}
        /// </remarks>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        public double Min
        {
            get;
            set;
        }
    }
}
