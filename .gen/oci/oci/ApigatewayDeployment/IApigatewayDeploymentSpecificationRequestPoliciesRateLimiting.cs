using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiInterface(nativeType: typeof(IApigatewayDeploymentSpecificationRequestPoliciesRateLimiting), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesRateLimiting")]
    public interface IApigatewayDeploymentSpecificationRequestPoliciesRateLimiting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#rate_in_requests_per_second ApigatewayDeployment#rate_in_requests_per_second}.</summary>
        [JsiiProperty(name: "rateInRequestsPerSecond", typeJson: "{\"primitive\":\"number\"}")]
        double RateInRequestsPerSecond
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#rate_key ApigatewayDeployment#rate_key}.</summary>
        [JsiiProperty(name: "rateKey", typeJson: "{\"primitive\":\"string\"}")]
        string RateKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayDeploymentSpecificationRequestPoliciesRateLimiting), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesRateLimiting")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesRateLimiting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#rate_in_requests_per_second ApigatewayDeployment#rate_in_requests_per_second}.</summary>
            [JsiiProperty(name: "rateInRequestsPerSecond", typeJson: "{\"primitive\":\"number\"}")]
            public double RateInRequestsPerSecond
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#rate_key ApigatewayDeployment#rate_key}.</summary>
            [JsiiProperty(name: "rateKey", typeJson: "{\"primitive\":\"string\"}")]
            public string RateKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
