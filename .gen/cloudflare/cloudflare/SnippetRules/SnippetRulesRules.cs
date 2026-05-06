using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.SnippetRules
{
    [JsiiByValue(fqn: "cloudflare.snippetRules.SnippetRulesRules")]
    public class SnippetRulesRules : cloudflare.SnippetRules.ISnippetRulesRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/snippet_rules#description SnippetRules#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/snippet_rules#enabled SnippetRules#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/snippet_rules#expression SnippetRules#expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expression
        {
            get;
            set;
        }

        /// <summary>Snippet identifying name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/snippet_rules#snippet_name SnippetRules#snippet_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snippetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnippetName
        {
            get;
            set;
        }
    }
}
