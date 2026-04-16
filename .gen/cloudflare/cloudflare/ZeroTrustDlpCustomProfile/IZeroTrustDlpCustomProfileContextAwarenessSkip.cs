using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpCustomProfile
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDlpCustomProfileContextAwarenessSkip), fullyQualifiedName: "cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileContextAwarenessSkip")]
    public interface IZeroTrustDlpCustomProfileContextAwarenessSkip
    {
        /// <summary>If the content type is a file, skip context analysis and return all matches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#files ZeroTrustDlpCustomProfile#files}
        /// </remarks>
        [JsiiProperty(name: "files", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Files
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDlpCustomProfileContextAwarenessSkip), fullyQualifiedName: "cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileContextAwarenessSkip")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDlpCustomProfile.IZeroTrustDlpCustomProfileContextAwarenessSkip
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If the content type is a file, skip context analysis and return all matches.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#files ZeroTrustDlpCustomProfile#files}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "files", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Files
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
