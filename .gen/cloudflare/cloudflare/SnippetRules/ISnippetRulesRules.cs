using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.SnippetRules
{
    [JsiiInterface(nativeType: typeof(ISnippetRulesRules), fullyQualifiedName: "cloudflare.snippetRules.SnippetRulesRules")]
    public interface ISnippetRulesRules
    {
        /// <summary>Define the expression that determines which traffic matches the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippet_rules#expression SnippetRules#expression}
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        string Expression
        {
            get;
        }

        /// <summary>Identify the snippet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippet_rules#snippet_name SnippetRules#snippet_name}
        /// </remarks>
        [JsiiProperty(name: "snippetName", typeJson: "{\"primitive\":\"string\"}")]
        string SnippetName
        {
            get;
        }

        /// <summary>Provide an informative description of the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippet_rules#description SnippetRules#description}
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicate whether to execute the rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippet_rules#enabled SnippetRules#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISnippetRulesRules), fullyQualifiedName: "cloudflare.snippetRules.SnippetRulesRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.SnippetRules.ISnippetRulesRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Define the expression that determines which traffic matches the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippet_rules#expression SnippetRules#expression}
            /// </remarks>
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
            public string Expression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identify the snippet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippet_rules#snippet_name SnippetRules#snippet_name}
            /// </remarks>
            [JsiiProperty(name: "snippetName", typeJson: "{\"primitive\":\"string\"}")]
            public string SnippetName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Provide an informative description of the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippet_rules#description SnippetRules#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicate whether to execute the rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/snippet_rules#enabled SnippetRules#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
