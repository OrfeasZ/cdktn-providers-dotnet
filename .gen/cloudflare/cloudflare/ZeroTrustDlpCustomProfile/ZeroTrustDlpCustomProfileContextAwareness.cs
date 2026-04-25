using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpCustomProfile
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileContextAwareness")]
    public class ZeroTrustDlpCustomProfileContextAwareness : cloudflare.ZeroTrustDlpCustomProfile.IZeroTrustDlpCustomProfileContextAwareness
    {
        private object? _enabled;

        /// <summary>If true, scan the context of predefined entries to only return matches surrounded by keywords.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_custom_profile#enabled ZeroTrustDlpCustomProfile#enabled}
        /// </remarks>
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

        /// <summary>Content types to exclude from context analysis and return all matches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_custom_profile#skip ZeroTrustDlpCustomProfile#skip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "skip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileContextAwarenessSkip\"}", isOptional: true)]
        public cloudflare.ZeroTrustDlpCustomProfile.IZeroTrustDlpCustomProfileContextAwarenessSkip? Skip
        {
            get;
            set;
        }
    }
}
