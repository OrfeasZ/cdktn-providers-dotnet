using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiInterface(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesResponsePoliciesResponseCacheStore), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesResponseCacheStore")]
    public interface IApigatewayDeploymentSpecificationRoutesResponsePoliciesResponseCacheStore
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#time_to_live_in_seconds ApigatewayDeployment#time_to_live_in_seconds}.</summary>
        [JsiiProperty(name: "timeToLiveInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double TimeToLiveInSeconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#type ApigatewayDeployment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesResponsePoliciesResponseCacheStore), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesResponseCacheStore")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesResponseCacheStore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#time_to_live_in_seconds ApigatewayDeployment#time_to_live_in_seconds}.</summary>
            [JsiiProperty(name: "timeToLiveInSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double TimeToLiveInSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#type ApigatewayDeployment#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
