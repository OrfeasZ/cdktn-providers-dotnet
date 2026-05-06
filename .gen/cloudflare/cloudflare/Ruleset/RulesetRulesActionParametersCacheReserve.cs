using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersCacheReserve")]
    public class RulesetRulesActionParametersCacheReserve : cloudflare.Ruleset.IRulesetRulesActionParametersCacheReserve
    {
        private object _eligible;

        /// <summary>Determines whether cache reserve is enabled.</summary>
        /// <remarks>
        /// If this is true and a request meets eligibility criteria, Cloudflare will write the resource to cache reserve.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#eligible Ruleset#eligible}
        /// </remarks>
        [JsiiProperty(name: "eligible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Eligible
        {
            get => _eligible;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _eligible = value;
            }
        }

        /// <summary>The minimum file size eligible for store in cache reserve.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#minimum_file_size Ruleset#minimum_file_size}
        /// </remarks>
        [JsiiProperty(name: "minimumFileSize", typeJson: "{\"primitive\":\"number\"}")]
        public double MinimumFileSize
        {
            get;
            set;
        }
    }
}
