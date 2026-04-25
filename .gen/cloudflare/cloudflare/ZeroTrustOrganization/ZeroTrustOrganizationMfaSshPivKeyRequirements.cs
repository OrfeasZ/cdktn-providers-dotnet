using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustOrganization
{
    [JsiiByValue(fqn: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationMfaSshPivKeyRequirements")]
    public class ZeroTrustOrganizationMfaSshPivKeyRequirements : cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationMfaSshPivKeyRequirements
    {
        /// <summary>Defines when a PIN is required to use the SSH key.</summary>
        /// <remarks>
        /// Valid values: <c>never</c> (no PIN required), <c>once</c> (PIN required once per session), <c>always</c> (PIN required for each use).
        /// Available values: "never", "once", "always".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#pin_policy ZeroTrustOrganization#pin_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pinPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PinPolicy
        {
            get;
            set;
        }

        private object? _requireFipsDevice;

        /// <summary>Requires the SSH PIV key to be stored on a FIPS 140-2 Level 1 or higher validated device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#require_fips_device ZeroTrustOrganization#require_fips_device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requireFipsDevice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RequireFipsDevice
        {
            get => _requireFipsDevice;
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
                _requireFipsDevice = value;
            }
        }

        /// <summary>Specifies the allowed SSH key sizes in bits.</summary>
        /// <remarks>
        /// Valid sizes depend on key type. Ed25519 has a fixed key size and does not accept this parameter.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#ssh_key_size ZeroTrustOrganization#ssh_key_size}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sshKeySize", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? SshKeySize
        {
            get;
            set;
        }

        /// <summary>Specifies the allowed SSH key types. Valid values are `ecdsa`, `ed25519`, and `rsa`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#ssh_key_type ZeroTrustOrganization#ssh_key_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sshKeyType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SshKeyType
        {
            get;
            set;
        }

        /// <summary>Defines when physical touch is required to use the SSH key.</summary>
        /// <remarks>
        /// Valid values: <c>never</c> (no touch required), <c>always</c> (touch required for each use), <c>cached</c> (touch cached for 15 seconds).
        /// Available values: "never", "always", "cached".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#touch_policy ZeroTrustOrganization#touch_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "touchPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TouchPolicy
        {
            get;
            set;
        }
    }
}
