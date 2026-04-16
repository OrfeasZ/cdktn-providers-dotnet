using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpEntry
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDlpEntryPattern), fullyQualifiedName: "cloudflare.zeroTrustDlpEntry.ZeroTrustDlpEntryPattern")]
    public interface IZeroTrustDlpEntryPattern
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_entry#regex ZeroTrustDlpEntry#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        string Regex
        {
            get;
        }

        /// <summary>Available values: "luhn".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_entry#validation ZeroTrustDlpEntry#validation}
        /// </remarks>
        [JsiiProperty(name: "validation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Validation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDlpEntryPattern), fullyQualifiedName: "cloudflare.zeroTrustDlpEntry.ZeroTrustDlpEntryPattern")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDlpEntry.IZeroTrustDlpEntryPattern
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_entry#regex ZeroTrustDlpEntry#regex}.</summary>
            [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
            public string Regex
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Available values: "luhn".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_entry#validation ZeroTrustDlpEntry#validation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Validation
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
