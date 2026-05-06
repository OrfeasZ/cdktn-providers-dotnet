using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpPredefinedProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDlpPredefinedProfile.ZeroTrustDlpPredefinedProfileContextAwareness")]
    public class ZeroTrustDlpPredefinedProfileContextAwareness : cloudflare.ZeroTrustDlpPredefinedProfile.IZeroTrustDlpPredefinedProfileContextAwareness
    {
        private object _enabled;

        /// <summary>If true, scan the context of predefined entries to only return matches surrounded by keywords.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dlp_predefined_profile#enabled ZeroTrustDlpPredefinedProfile#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Enabled
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Content types to exclude from context analysis and return all matches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dlp_predefined_profile#skip ZeroTrustDlpPredefinedProfile#skip}
        /// </remarks>
        [JsiiProperty(name: "skip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpPredefinedProfile.ZeroTrustDlpPredefinedProfileContextAwarenessSkip\"}")]
        public cloudflare.ZeroTrustDlpPredefinedProfile.IZeroTrustDlpPredefinedProfileContextAwarenessSkip Skip
        {
            get;
            set;
        }
    }
}
