using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Filter
{
    [JsiiByValue(fqn: "cloudflare.filter.FilterBody")]
    public class FilterBody : cloudflare.Filter.IFilterBody
    {
        /// <summary>An informative summary of the filter.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/filter#description Filter#description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>The filter expression. For more information, refer to [Expressions](https://developers.cloudflare.com/ruleset-engine/rules-language/expressions/).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/filter#expression Filter#expression}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expression
        {
            get;
            set;
        }

        private object? _paused;

        /// <summary>When true, indicates that the filter is currently paused.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/filter#paused Filter#paused}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paused", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Paused
        {
            get => _paused;
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
                _paused = value;
            }
        }

        /// <summary>A short reference tag. Allows you to select related filters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/filter#ref Filter#ref}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ref", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ref
        {
            get;
            set;
        }
    }
}
