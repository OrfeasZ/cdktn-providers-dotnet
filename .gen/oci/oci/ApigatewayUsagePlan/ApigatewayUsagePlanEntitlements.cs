using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayUsagePlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlements")]
    public class ApigatewayUsagePlanEntitlements : oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlements
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#name ApigatewayUsagePlan#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#description ApigatewayUsagePlan#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>quota block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#quota ApigatewayUsagePlan#quota}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "quota", typeJson: "{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsQuota\"}", isOptional: true)]
        public oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsQuota? Quota
        {
            get;
            set;
        }

        /// <summary>rate_limit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#rate_limit ApigatewayUsagePlan#rate_limit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rateLimit", typeJson: "{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsRateLimit\"}", isOptional: true)]
        public oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsRateLimit? RateLimit
        {
            get;
            set;
        }

        private object? _targets;

        /// <summary>targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_usage_plan#targets ApigatewayUsagePlan#targets}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayUsagePlan.ApigatewayUsagePlanEntitlementsTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Targets
        {
            get => _targets;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsTargets[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayUsagePlan.IApigatewayUsagePlanEntitlementsTargets).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _targets = value;
            }
        }
    }
}
