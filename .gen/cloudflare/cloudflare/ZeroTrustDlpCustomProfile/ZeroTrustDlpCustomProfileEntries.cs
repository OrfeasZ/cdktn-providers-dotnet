using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpCustomProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileEntries")]
    public class ZeroTrustDlpCustomProfileEntries : cloudflare.ZeroTrustDlpCustomProfile.IZeroTrustDlpCustomProfileEntries
    {
        private object _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#enabled ZeroTrustDlpCustomProfile#enabled}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#name ZeroTrustDlpCustomProfile#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#pattern ZeroTrustDlpCustomProfile#pattern}.</summary>
        [JsiiProperty(name: "pattern", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpCustomProfile.ZeroTrustDlpCustomProfileEntriesPattern\"}")]
        public cloudflare.ZeroTrustDlpCustomProfile.IZeroTrustDlpCustomProfileEntriesPattern Pattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#description ZeroTrustDlpCustomProfile#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zero_trust_dlp_custom_profile#entry_id ZeroTrustDlpCustomProfile#entry_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "entryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EntryId
        {
            get;
            set;
        }
    }
}
