using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Filter
{
    [JsiiInterface(nativeType: typeof(IFilterBody), fullyQualifiedName: "cloudflare.filter.FilterBody")]
    public interface IFilterBody
    {
        /// <summary>An informative summary of the filter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/filter#description Filter#description}
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

        /// <summary>The filter expression. For more information, refer to [Expressions](https://developers.cloudflare.com/ruleset-engine/rules-language/expressions/).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/filter#expression Filter#expression}
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expression
        {
            get
            {
                return null;
            }
        }

        /// <summary>When true, indicates that the filter is currently paused.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/filter#paused Filter#paused}
        /// </remarks>
        [JsiiProperty(name: "paused", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Paused
        {
            get
            {
                return null;
            }
        }

        /// <summary>A short reference tag. Allows you to select related filters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/filter#ref Filter#ref}
        /// </remarks>
        [JsiiProperty(name: "ref", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ref
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFilterBody), fullyQualifiedName: "cloudflare.filter.FilterBody")]
        internal sealed class _Proxy : DeputyBase, cloudflare.Filter.IFilterBody
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>An informative summary of the filter.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/filter#description Filter#description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The filter expression. For more information, refer to [Expressions](https://developers.cloudflare.com/ruleset-engine/rules-language/expressions/).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/filter#expression Filter#expression}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When true, indicates that the filter is currently paused.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/filter#paused Filter#paused}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paused", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Paused
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A short reference tag. Allows you to select related filters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/filter#ref Filter#ref}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ref", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ref
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
