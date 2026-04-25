using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustDlpSettings
{
    [JsiiInterface(nativeType: typeof(IZeroTrustDlpSettingsConfig), fullyQualifiedName: "cloudflare.zeroTrustDlpSettings.ZeroTrustDlpSettingsConfig")]
    public interface IZeroTrustDlpSettingsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_settings#account_id ZeroTrustDlpSettings#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Whether AI context analysis is enabled at the account level.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_settings#ai_context_analysis ZeroTrustDlpSettings#ai_context_analysis}
        /// </remarks>
        [JsiiProperty(name: "aiContextAnalysis", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AiContextAnalysis
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether OCR is enabled at the account level.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_settings#ocr ZeroTrustDlpSettings#ocr}
        /// </remarks>
        [JsiiProperty(name: "ocr", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ocr
        {
            get
            {
                return null;
            }
        }

        /// <summary>Request model for payload log settings within the DLP settings endpoint.</summary>
        /// <remarks>
        /// Unlike the legacy endpoint, null and missing are treated identically here
        /// (both mean "not provided" for PATCH, "reset to default" for PUT).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_settings#payload_logging ZeroTrustDlpSettings#payload_logging}
        /// </remarks>
        [JsiiProperty(name: "payloadLogging", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpSettings.ZeroTrustDlpSettingsPayloadLogging\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ZeroTrustDlpSettings.IZeroTrustDlpSettingsPayloadLogging? PayloadLogging
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustDlpSettingsConfig), fullyQualifiedName: "cloudflare.zeroTrustDlpSettings.ZeroTrustDlpSettingsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustDlpSettings.IZeroTrustDlpSettingsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_settings#account_id ZeroTrustDlpSettings#account_id}.</summary>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Whether AI context analysis is enabled at the account level.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_settings#ai_context_analysis ZeroTrustDlpSettings#ai_context_analysis}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aiContextAnalysis", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AiContextAnalysis
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether OCR is enabled at the account level.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_settings#ocr ZeroTrustDlpSettings#ocr}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ocr", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Ocr
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Request model for payload log settings within the DLP settings endpoint.</summary>
            /// <remarks>
            /// Unlike the legacy endpoint, null and missing are treated identically here
            /// (both mean "not provided" for PATCH, "reset to default" for PUT).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_dlp_settings#payload_logging ZeroTrustDlpSettings#payload_logging}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "payloadLogging", typeJson: "{\"fqn\":\"cloudflare.zeroTrustDlpSettings.ZeroTrustDlpSettingsPayloadLogging\"}", isOptional: true)]
            public cloudflare.ZeroTrustDlpSettings.IZeroTrustDlpSettingsPayloadLogging? PayloadLogging
            {
                get => GetInstanceProperty<cloudflare.ZeroTrustDlpSettings.IZeroTrustDlpSettingsPayloadLogging?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
