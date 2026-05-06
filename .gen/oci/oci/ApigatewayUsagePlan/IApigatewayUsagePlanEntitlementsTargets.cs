using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayUsagePlan
{
    [JsiiInterface(nativeType: typeof(IApigatewayUsagePlanEntitlementsTargets), fullyQualifiedName: "oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsTargets")]
    public interface IApigatewayUsagePlanEntitlementsTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#deployment_id ApigatewayUsagePlan#deployment_id}.</summary>
        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}")]
        string DeploymentId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayUsagePlanEntitlementsTargets), fullyQualifiedName: "oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsTargets")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsTargets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#deployment_id ApigatewayUsagePlan#deployment_id}.</summary>
            [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}")]
            public string DeploymentId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
