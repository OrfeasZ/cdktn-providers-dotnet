using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.TokenValidationRules
{
    [JsiiByValue(fqn: "cloudflare.tokenValidationRules.TokenValidationRulesSelector")]
    public class TokenValidationRulesSelector : cloudflare.TokenValidationRules.ITokenValidationRulesSelector
    {
        private object? _exclude;

        /// <summary>Ignore operations that were otherwise included by `include`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#exclude TokenValidationRules#exclude}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclude", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.tokenValidationRules.TokenValidationRulesSelectorExclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Exclude
        {
            get => _exclude;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.TokenValidationRules.ITokenValidationRulesSelectorExclude[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.TokenValidationRules.ITokenValidationRulesSelectorExclude).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exclude = value;
            }
        }

        private object? _include;

        /// <summary>Select all matching operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/token_validation_rules#include TokenValidationRules#include}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "include", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.tokenValidationRules.TokenValidationRulesSelectorInclude\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Include
        {
            get => _include;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case cloudflare.TokenValidationRules.ITokenValidationRulesSelectorInclude[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.TokenValidationRules.ITokenValidationRulesSelectorInclude).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _include = value;
            }
        }
    }
}
