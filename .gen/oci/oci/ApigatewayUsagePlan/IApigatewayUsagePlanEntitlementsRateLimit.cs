using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayUsagePlan
{
    [JsiiInterface(nativeType: typeof(IApigatewayUsagePlanEntitlementsRateLimit), fullyQualifiedName: "oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsRateLimit")]
    public interface IApigatewayUsagePlanEntitlementsRateLimit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#unit ApigatewayUsagePlan#unit}.</summary>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        string Unit
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#value ApigatewayUsagePlan#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayUsagePlanEntitlementsRateLimit), fullyQualifiedName: "oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsRateLimit")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsRateLimit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#unit ApigatewayUsagePlan#unit}.</summary>
            [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
            public string Unit
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#value ApigatewayUsagePlan#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
