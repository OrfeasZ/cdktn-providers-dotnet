using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustOrganization
{
    [JsiiInterface(nativeType: typeof(IZeroTrustOrganizationMfaSshPivKeyRequirements), fullyQualifiedName: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationMfaSshPivKeyRequirements")]
    public interface IZeroTrustOrganizationMfaSshPivKeyRequirements
    {
        /// <summary>Defines when a PIN is required to use the SSH key.</summary>
        /// <remarks>
        /// Valid values: <c>never</c> (no PIN required), <c>once</c> (PIN required once per session), <c>always</c> (PIN required for each use).
        /// Available values: "never", "once", "always".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#pin_policy ZeroTrustOrganization#pin_policy}
        /// </remarks>
        [JsiiProperty(name: "pinPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PinPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Requires the SSH PIV key to be stored on a FIPS 140-2 Level 1 or higher validated device.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#require_fips_device ZeroTrustOrganization#require_fips_device}
        /// </remarks>
        [JsiiProperty(name: "requireFipsDevice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequireFipsDevice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the allowed SSH key sizes in bits.</summary>
        /// <remarks>
        /// Valid sizes depend on key type. Ed25519 has a fixed key size and does not accept this parameter.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#ssh_key_size ZeroTrustOrganization#ssh_key_size}
        /// </remarks>
        [JsiiProperty(name: "sshKeySize", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? SshKeySize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the allowed SSH key types. Valid values are `ecdsa`, `ed25519`, and `rsa`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#ssh_key_type ZeroTrustOrganization#ssh_key_type}
        /// </remarks>
        [JsiiProperty(name: "sshKeyType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SshKeyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines when physical touch is required to use the SSH key.</summary>
        /// <remarks>
        /// Valid values: <c>never</c> (no touch required), <c>always</c> (touch required for each use), <c>cached</c> (touch cached for 15 seconds).
        /// Available values: "never", "always", "cached".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#touch_policy ZeroTrustOrganization#touch_policy}
        /// </remarks>
        [JsiiProperty(name: "touchPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TouchPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustOrganizationMfaSshPivKeyRequirements), fullyQualifiedName: "cloudflare.zeroTrustOrganization.ZeroTrustOrganizationMfaSshPivKeyRequirements")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustOrganization.IZeroTrustOrganizationMfaSshPivKeyRequirements
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Requires the SSH PIV key to be stored on a FIPS 140-2 Level 1 or higher validated device.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#require_fips_device ZeroTrustOrganization#require_fips_device}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requireFipsDevice", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequireFipsDevice
            {
                get => GetInstanceProperty<object?>();
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
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Specifies the allowed SSH key types. Valid values are `ecdsa`, `ed25519`, and `rsa`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_organization#ssh_key_type ZeroTrustOrganization#ssh_key_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sshKeyType", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SshKeyType
            {
                get => GetInstanceProperty<string[]?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
