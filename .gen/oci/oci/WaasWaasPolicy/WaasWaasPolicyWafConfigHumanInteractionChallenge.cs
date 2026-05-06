using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallenge")]
    public class WaasWaasPolicyWafConfigHumanInteractionChallenge : oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallenge
    {
        private object _isEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_enabled WaasWaasPolicy#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsEnabled
        {
            get => _isEnabled;
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
                _isEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#action WaasWaasPolicy#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#action_expiration_in_seconds WaasWaasPolicy#action_expiration_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ActionExpirationInSeconds
        {
            get;
            set;
        }

        /// <summary>challenge_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#challenge_settings WaasWaasPolicy#challenge_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "challengeSettings", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallengeChallengeSettings\"}", isOptional: true)]
        public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallengeChallengeSettings? ChallengeSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#failure_threshold WaasWaasPolicy#failure_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#failure_threshold_expiration_in_seconds WaasWaasPolicy#failure_threshold_expiration_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "failureThresholdExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FailureThresholdExpirationInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#interaction_threshold WaasWaasPolicy#interaction_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interactionThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InteractionThreshold
        {
            get;
            set;
        }

        private object? _isNatEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_nat_enabled WaasWaasPolicy#is_nat_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isNatEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsNatEnabled
        {
            get => _isNatEnabled;
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
                _isNatEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#recording_period_in_seconds WaasWaasPolicy#recording_period_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recordingPeriodInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RecordingPeriodInSeconds
        {
            get;
            set;
        }

        /// <summary>set_http_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#set_http_header WaasWaasPolicy#set_http_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setHttpHeader", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallengeSetHttpHeader\"}", isOptional: true)]
        public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallengeSetHttpHeader? SetHttpHeader
        {
            get;
            set;
        }
    }
}
