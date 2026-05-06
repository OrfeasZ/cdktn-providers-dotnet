using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.Ruleset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.ruleset.RulesetRulesActionParametersServeStale")]
    public class RulesetRulesActionParametersServeStale : cloudflare.Ruleset.IRulesetRulesActionParametersServeStale
    {
        private object _disableStaleWhileUpdating;

        /// <summary>Defines whether Cloudflare should serve stale content while updating.</summary>
        /// <remarks>
        /// If true, Cloudflare will not serve stale content while getting the latest content from the origin.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/ruleset#disable_stale_while_updating Ruleset#disable_stale_while_updating}
        /// </remarks>
        [JsiiProperty(name: "disableStaleWhileUpdating", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object DisableStaleWhileUpdating
        {
            get => _disableStaleWhileUpdating;
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
                _disableStaleWhileUpdating = value;
            }
        }
    }
}
