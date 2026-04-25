using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationRules
{
    [JsiiInterface(nativeType: typeof(ITokenValidationRulesSelector), fullyQualifiedName: "cloudflare.tokenValidationRules.TokenValidationRulesSelector")]
    public interface ITokenValidationRulesSelector
    {
        /// <summary>Ignore operations that were otherwise included by `include`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/token_validation_rules#exclude TokenValidationRules#exclude}
        /// </remarks>
        [JsiiProperty(name: "exclude", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.tokenValidationRules.TokenValidationRulesSelectorExclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Exclude
        {
            get
            {
                return null;
            }
        }

        /// <summary>Select all matching operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/token_validation_rules#include TokenValidationRules#include}
        /// </remarks>
        [JsiiProperty(name: "include", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.tokenValidationRules.TokenValidationRulesSelectorInclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Include
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITokenValidationRulesSelector), fullyQualifiedName: "cloudflare.tokenValidationRules.TokenValidationRulesSelector")]
        internal sealed class _Proxy : DeputyBase, cloudflare.TokenValidationRules.ITokenValidationRulesSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Ignore operations that were otherwise included by `include`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/token_validation_rules#exclude TokenValidationRules#exclude}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exclude", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.tokenValidationRules.TokenValidationRulesSelectorExclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Exclude
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Select all matching operations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/token_validation_rules#include TokenValidationRules#include}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "include", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.tokenValidationRules.TokenValidationRulesSelectorInclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Include
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
