using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    [JsiiInterface(nativeType: typeof(IRulesetRulesActionParametersFromValue), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersFromValue")]
    public interface IRulesetRulesActionParametersFromValue
    {
        /// <summary>A URL to redirect the request to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#target_url Ruleset#target_url}
        /// </remarks>
        [JsiiProperty(name: "targetUrl", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersFromValueTargetUrl\"}")]
        cloudflare.Ruleset.IRulesetRulesActionParametersFromValueTargetUrl TargetUrl
        {
            get;
        }

        /// <summary>Whether to keep the query string of the original request.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#preserve_query_string Ruleset#preserve_query_string}
        /// </remarks>
        [JsiiProperty(name: "preserveQueryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PreserveQueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>The status code to use for the redirect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#status_code Ruleset#status_code}
        /// </remarks>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StatusCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRulesetRulesActionParametersFromValue), fullyQualifiedName: "cloudflare.ruleset.RulesetRulesActionParametersFromValue")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Ruleset.IRulesetRulesActionParametersFromValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A URL to redirect the request to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#target_url Ruleset#target_url}
            /// </remarks>
            [JsiiProperty(name: "targetUrl", typeJson: "{\"fqn\":\"cloudflare.ruleset.RulesetRulesActionParametersFromValueTargetUrl\"}")]
            public cloudflare.Ruleset.IRulesetRulesActionParametersFromValueTargetUrl TargetUrl
            {
                get => GetInstanceProperty<cloudflare.Ruleset.IRulesetRulesActionParametersFromValueTargetUrl>()!;
            }

            /// <summary>Whether to keep the query string of the original request.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#preserve_query_string Ruleset#preserve_query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preserveQueryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PreserveQueryString
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The status code to use for the redirect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/ruleset#status_code Ruleset#status_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StatusCode
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
