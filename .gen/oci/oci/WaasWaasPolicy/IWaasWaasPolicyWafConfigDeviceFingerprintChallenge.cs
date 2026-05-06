using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyWafConfigDeviceFingerprintChallenge), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallenge")]
    public interface IWaasWaasPolicyWafConfigDeviceFingerprintChallenge
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

        /// <summary>challenge_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#challenge_settings WaasWaasPolicy#challenge_settings}
        /// </remarks>
        [JsiiProperty(name: "challengeSettings", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings? ChallengeSettings
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#failure_threshold_expiration_in_seconds WaasWaasPolicy#failure_threshold_expiration_in_seconds}.</summary>
        [JsiiProperty(name: "failureThresholdExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailureThresholdExpirationInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#max_address_count WaasWaasPolicy#max_address_count}.</summary>
        [JsiiProperty(name: "maxAddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAddressCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#max_address_count_expiration_in_seconds WaasWaasPolicy#max_address_count_expiration_in_seconds}.</summary>
        [JsiiProperty(name: "maxAddressCountExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAddressCountExpirationInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyWafConfigDeviceFingerprintChallenge), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallenge")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallenge
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

            /// <summary>challenge_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#challenge_settings WaasWaasPolicy#challenge_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "challengeSettings", typeJson: "{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings\"}", isOptional: true)]
            public oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings? ChallengeSettings
            {
                get => GetInstanceProperty<oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#failure_threshold WaasWaasPolicy#failure_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failureThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailureThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#failure_threshold_expiration_in_seconds WaasWaasPolicy#failure_threshold_expiration_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failureThresholdExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailureThresholdExpirationInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#max_address_count WaasWaasPolicy#max_address_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxAddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAddressCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#max_address_count_expiration_in_seconds WaasWaasPolicy#max_address_count_expiration_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxAddressCountExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAddressCountExpirationInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
