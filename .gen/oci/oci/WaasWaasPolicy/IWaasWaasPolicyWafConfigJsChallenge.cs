using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyWafConfigJsChallenge), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallenge")]
    public interface IWaasWaasPolicyWafConfigJsChallenge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_enabled WaasWaasPolicy#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#action WaasWaasPolicy#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#action_expiration_in_seconds WaasWaasPolicy#action_expiration_in_seconds}.</summary>
        [JsiiProperty(name: "actionExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ActionExpirationInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#are_redirects_challenged WaasWaasPolicy#are_redirects_challenged}.</summary>
        [JsiiProperty(name: "areRedirectsChallenged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AreRedirectsChallenged
        {
            get
            {
                return null;
            }
        }

        /// <summary>challenge_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#challenge_settings WaasWaasPolicy#challenge_settings}
        /// </remarks>
        [JsiiProperty(name: "challengeSettings", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallengeChallengeSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallengeChallengeSettings? ChallengeSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#criteria WaasWaasPolicy#criteria}
        /// </remarks>
        [JsiiProperty(name: "criteria", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallengeCriteria\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Criteria
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#failure_threshold WaasWaasPolicy#failure_threshold}.</summary>
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailureThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_nat_enabled WaasWaasPolicy#is_nat_enabled}.</summary>
        [JsiiProperty(name: "isNatEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsNatEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>set_http_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#set_http_header WaasWaasPolicy#set_http_header}
        /// </remarks>
        [JsiiProperty(name: "setHttpHeader", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallengeSetHttpHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallengeSetHttpHeader? SetHttpHeader
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyWafConfigJsChallenge), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallenge")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallenge
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_enabled WaasWaasPolicy#is_enabled}.</summary>
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#action WaasWaasPolicy#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#action_expiration_in_seconds WaasWaasPolicy#action_expiration_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ActionExpirationInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#are_redirects_challenged WaasWaasPolicy#are_redirects_challenged}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "areRedirectsChallenged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AreRedirectsChallenged
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>challenge_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#challenge_settings WaasWaasPolicy#challenge_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "challengeSettings", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallengeChallengeSettings\"}", isOptional: true)]
            public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallengeChallengeSettings? ChallengeSettings
            {
                get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallengeChallengeSettings?>();
            }

            /// <summary>criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#criteria WaasWaasPolicy#criteria}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "criteria", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallengeCriteria\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Criteria
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#failure_threshold WaasWaasPolicy#failure_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailureThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_nat_enabled WaasWaasPolicy#is_nat_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isNatEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsNatEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>set_http_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#set_http_header WaasWaasPolicy#set_http_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setHttpHeader", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigJsChallengeSetHttpHeader\"}", isOptional: true)]
            public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallengeSetHttpHeader? SetHttpHeader
            {
                get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigJsChallengeSetHttpHeader?>();
            }
        }
    }
}
