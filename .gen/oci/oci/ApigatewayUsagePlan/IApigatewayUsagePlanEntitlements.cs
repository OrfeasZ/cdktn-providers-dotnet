using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayUsagePlan
{
    [JsiiInterface(nativeType: typeof(IApigatewayUsagePlanEntitlements), fullyQualifiedName: "oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlements")]
    public interface IApigatewayUsagePlanEntitlements
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#name ApigatewayUsagePlan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#description ApigatewayUsagePlan#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>quota block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#quota ApigatewayUsagePlan#quota}
        /// </remarks>
        [JsiiProperty(name: "quota", typeJson: "{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsQuota\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsQuota? Quota
        {
            get
            {
                return null;
            }
        }

        /// <summary>rate_limit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#rate_limit ApigatewayUsagePlan#rate_limit}
        /// </remarks>
        [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsRateLimit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsRateLimit? RateLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#targets ApigatewayUsagePlan#targets}
        /// </remarks>
        [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Targets
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayUsagePlanEntitlements), fullyQualifiedName: "oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlements")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlements
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#name ApigatewayUsagePlan#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#description ApigatewayUsagePlan#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>quota block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#quota ApigatewayUsagePlan#quota}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quota", typeJson: "{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsQuota\"}", isOptional: true)]
            public oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsQuota? Quota
            {
                get => GetInstanceProperty<oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsQuota?>();
            }

            /// <summary>rate_limit block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#rate_limit ApigatewayUsagePlan#rate_limit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsRateLimit\"}", isOptional: true)]
            public oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsRateLimit? RateLimit
            {
                get => GetInstanceProperty<oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsRateLimit?>();
            }

            /// <summary>targets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#targets ApigatewayUsagePlan#targets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Targets
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
