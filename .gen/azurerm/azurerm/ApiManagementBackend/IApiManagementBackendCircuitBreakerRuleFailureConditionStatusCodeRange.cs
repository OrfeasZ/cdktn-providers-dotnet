using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiInterface(nativeType: typeof(IApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange")]
    public interface IApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange
    {
        /// <summary>The maximum HTTP status code to consider as a failure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#max ApiManagementBackend#max}
        /// </remarks>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        double Max
        {
            get;
        }

        /// <summary>The minimum HTTP status code to consider as a failure.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#min ApiManagementBackend#min}
        /// </remarks>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        double Min
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementBackend.IApiManagementBackendCircuitBreakerRuleFailureConditionStatusCodeRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The maximum HTTP status code to consider as a failure.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#max ApiManagementBackend#max}
            /// </remarks>
            [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
            public double Max
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The minimum HTTP status code to consider as a failure.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#min ApiManagementBackend#min}
            /// </remarks>
            [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
            public double Min
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
