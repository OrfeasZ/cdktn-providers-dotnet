using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpPredefinedProfile
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDlpPredefinedProfileContextAwareness), fullyQualifiedName: "cloudflare.zeroTrustDlpPredefinedProfile.ZeroTrustDlpPredefinedProfileContextAwareness")]
    public interface IZeroTrustDlpPredefinedProfileContextAwareness
    {
        /// <summary>If true, scan the context of predefined entries to only return matches surrounded by keywords.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dlp_predefined_profile#enabled ZeroTrustDlpPredefinedProfile#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Content types to exclude from context analysis and return all matches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dlp_predefined_profile#skip ZeroTrustDlpPredefinedProfile#skip}
        /// </remarks>
        [JsiiProperty(name: "skip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpPredefinedProfile.ZeroTrustDlpPredefinedProfileContextAwarenessSkip\"}")]
        cloudflare.ZeroTrustDlpPredefinedProfile.IZeroTrustDlpPredefinedProfileContextAwarenessSkip Skip
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDlpPredefinedProfileContextAwareness), fullyQualifiedName: "cloudflare.zeroTrustDlpPredefinedProfile.ZeroTrustDlpPredefinedProfileContextAwareness")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDlpPredefinedProfile.IZeroTrustDlpPredefinedProfileContextAwareness
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If true, scan the context of predefined entries to only return matches surrounded by keywords.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dlp_predefined_profile#enabled ZeroTrustDlpPredefinedProfile#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Content types to exclude from context analysis and return all matches.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/zero_trust_dlp_predefined_profile#skip ZeroTrustDlpPredefinedProfile#skip}
            /// </remarks>
            [JsiiProperty(name: "skip", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpPredefinedProfile.ZeroTrustDlpPredefinedProfileContextAwarenessSkip\"}")]
            public cloudflare.ZeroTrustDlpPredefinedProfile.IZeroTrustDlpPredefinedProfileContextAwarenessSkip Skip
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustDlpPredefinedProfile.IZeroTrustDlpPredefinedProfileContextAwarenessSkip>()!;
            }
        }
    }
}
