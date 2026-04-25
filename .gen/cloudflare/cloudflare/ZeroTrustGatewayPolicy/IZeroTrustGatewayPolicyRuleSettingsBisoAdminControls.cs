using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustGatewayPolicy
{
    [JsiiInterface(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsBisoAdminControls), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBisoAdminControls")]
    public interface IZeroTrustGatewayPolicyRuleSettingsBisoAdminControls
    {
        /// <summary>Configure copy behavior.</summary>
        /// <remarks>
        /// If set to remote_only, users cannot copy isolated content from the remote browser to the local clipboard. If this field is absent, copying remains enabled. Applies only when version == "v2".
        /// Available values: "enabled", "disabled", "remote_only".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#copy ZeroTrustGatewayPolicy#copy}
        /// </remarks>
        [JsiiProperty(name: "copy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Copy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to false to enable copy-pasting. Only applies when `version == "v1"`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#dcp ZeroTrustGatewayPolicy#dcp}
        /// </remarks>
        [JsiiProperty(name: "dcp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Dcp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to false to enable downloading. Only applies when `version == "v1"`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#dd ZeroTrustGatewayPolicy#dd}
        /// </remarks>
        [JsiiProperty(name: "dd", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Dd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to false to enable keyboard usage. Only applies when `version == "v1"`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#dk ZeroTrustGatewayPolicy#dk}
        /// </remarks>
        [JsiiProperty(name: "dk", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Dk
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure download behavior.</summary>
        /// <remarks>
        /// When set to remote_only, users can view downloads but cannot save them. If this field is absent, downloading remains enabled. Applies only when version == "v2".
        /// Available values: "enabled", "disabled", "remote_only".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#download ZeroTrustGatewayPolicy#download}
        /// </remarks>
        [JsiiProperty(name: "download", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Download
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to false to enable printing. Only applies when `version == "v1"`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#dp ZeroTrustGatewayPolicy#dp}
        /// </remarks>
        [JsiiProperty(name: "dp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Dp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Set to false to enable uploading. Only applies when `version == "v1"`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#du ZeroTrustGatewayPolicy#du}
        /// </remarks>
        [JsiiProperty(name: "du", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Du
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure keyboard usage behavior.</summary>
        /// <remarks>
        /// If this field is absent, keyboard usage remains enabled. Applies only when version == "v2".
        /// Available values: "enabled", "disabled".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#keyboard ZeroTrustGatewayPolicy#keyboard}
        /// </remarks>
        [JsiiProperty(name: "keyboard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Keyboard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure paste behavior.</summary>
        /// <remarks>
        /// If set to remote_only, users cannot paste content from the local clipboard into isolated pages. If this field is absent, pasting remains enabled. Applies only when version == "v2".
        /// Available values: "enabled", "disabled", "remote_only".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#paste ZeroTrustGatewayPolicy#paste}
        /// </remarks>
        [JsiiProperty(name: "paste", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Paste
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure print behavior. Default, Printing is enabled. Applies only when version == "v2". Available values: "enabled", "disabled".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#printing ZeroTrustGatewayPolicy#printing}
        /// </remarks>
        [JsiiProperty(name: "printing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Printing
        {
            get
            {
                return null;
            }
        }

        /// <summary>Configure upload behavior.</summary>
        /// <remarks>
        /// If this field is absent, uploading remains enabled. Applies only when version == "v2".
        /// Available values: "enabled", "disabled".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#upload ZeroTrustGatewayPolicy#upload}
        /// </remarks>
        [JsiiProperty(name: "upload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Upload
        {
            get
            {
                return null;
            }
        }

        /// <summary>Indicate which version of the browser isolation controls should apply. Available values: "v1", "v2".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#version ZeroTrustGatewayPolicy#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the watermark ID (UUID) to apply to the isolated browser session.</summary>
        /// <remarks>
        /// When present, enables watermark rendering in the isolated browser.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#wm_id ZeroTrustGatewayPolicy#wm_id}
        /// </remarks>
        [JsiiProperty(name: "wmId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WmId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZeroTrustGatewayPolicyRuleSettingsBisoAdminControls), fullyQualifiedName: "cloudflare.zeroTrustGatewayPolicy.ZeroTrustGatewayPolicyRuleSettingsBisoAdminControls")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZeroTrustGatewayPolicy.IZeroTrustGatewayPolicyRuleSettingsBisoAdminControls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Configure copy behavior.</summary>
            /// <remarks>
            /// If set to remote_only, users cannot copy isolated content from the remote browser to the local clipboard. If this field is absent, copying remains enabled. Applies only when version == "v2".
            /// Available values: "enabled", "disabled", "remote_only".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#copy ZeroTrustGatewayPolicy#copy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "copy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Copy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set to false to enable copy-pasting. Only applies when `version == "v1"`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#dcp ZeroTrustGatewayPolicy#dcp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dcp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Dcp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Set to false to enable downloading. Only applies when `version == "v1"`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#dd ZeroTrustGatewayPolicy#dd}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dd", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Dd
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Set to false to enable keyboard usage. Only applies when `version == "v1"`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#dk ZeroTrustGatewayPolicy#dk}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dk", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Dk
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configure download behavior.</summary>
            /// <remarks>
            /// When set to remote_only, users can view downloads but cannot save them. If this field is absent, downloading remains enabled. Applies only when version == "v2".
            /// Available values: "enabled", "disabled", "remote_only".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#download ZeroTrustGatewayPolicy#download}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "download", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Download
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Set to false to enable printing. Only applies when `version == "v1"`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#dp ZeroTrustGatewayPolicy#dp}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Dp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Set to false to enable uploading. Only applies when `version == "v1"`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#du ZeroTrustGatewayPolicy#du}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "du", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Du
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Configure keyboard usage behavior.</summary>
            /// <remarks>
            /// If this field is absent, keyboard usage remains enabled. Applies only when version == "v2".
            /// Available values: "enabled", "disabled".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#keyboard ZeroTrustGatewayPolicy#keyboard}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyboard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Keyboard
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configure paste behavior.</summary>
            /// <remarks>
            /// If set to remote_only, users cannot paste content from the local clipboard into isolated pages. If this field is absent, pasting remains enabled. Applies only when version == "v2".
            /// Available values: "enabled", "disabled", "remote_only".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#paste ZeroTrustGatewayPolicy#paste}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "paste", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Paste
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configure print behavior. Default, Printing is enabled. Applies only when version == "v2". Available values: "enabled", "disabled".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#printing ZeroTrustGatewayPolicy#printing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "printing", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Printing
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Configure upload behavior.</summary>
            /// <remarks>
            /// If this field is absent, uploading remains enabled. Applies only when version == "v2".
            /// Available values: "enabled", "disabled".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#upload ZeroTrustGatewayPolicy#upload}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Upload
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Indicate which version of the browser isolation controls should apply. Available values: "v1", "v2".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#version ZeroTrustGatewayPolicy#version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify the watermark ID (UUID) to apply to the isolated browser session.</summary>
            /// <remarks>
            /// When present, enables watermark rendering in the isolated browser.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/zero_trust_gateway_policy#wm_id ZeroTrustGatewayPolicy#wm_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wmId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WmId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
