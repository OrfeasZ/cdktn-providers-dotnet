using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpCustomProfile
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDlpCustomProfileEntries), fullyQualifiedName: "cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileEntries")]
    public interface IZeroTrustDlpCustomProfileEntries
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#enabled ZeroTrustDlpCustomProfile#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#name ZeroTrustDlpCustomProfile#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#pattern ZeroTrustDlpCustomProfile#pattern}.</summary>
        [JsiiProperty(name: "pattern", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileEntriesPattern\"}")]
        cloudflare.ZeroTrustDlpCustomProfile.IZeroTrustDlpCustomProfileEntriesPattern Pattern
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#description ZeroTrustDlpCustomProfile#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#entry_id ZeroTrustDlpCustomProfile#entry_id}.</summary>
        [JsiiProperty(name: "entryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EntryId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDlpCustomProfileEntries), fullyQualifiedName: "cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileEntries")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDlpCustomProfile.IZeroTrustDlpCustomProfileEntries
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#enabled ZeroTrustDlpCustomProfile#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#name ZeroTrustDlpCustomProfile#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#pattern ZeroTrustDlpCustomProfile#pattern}.</summary>
            [JsiiProperty(name: "pattern", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileEntriesPattern\"}")]
            public cloudflare.ZeroTrustDlpCustomProfile.IZeroTrustDlpCustomProfileEntriesPattern Pattern
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustDlpCustomProfile.IZeroTrustDlpCustomProfileEntriesPattern>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#description ZeroTrustDlpCustomProfile#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#entry_id ZeroTrustDlpCustomProfile#entry_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "entryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EntryId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
