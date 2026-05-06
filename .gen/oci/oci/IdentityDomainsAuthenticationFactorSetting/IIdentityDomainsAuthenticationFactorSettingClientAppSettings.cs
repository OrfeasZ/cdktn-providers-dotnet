using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthenticationFactorSetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAuthenticationFactorSettingClientAppSettings), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingClientAppSettings")]
    public interface IIdentityDomainsAuthenticationFactorSettingClientAppSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#device_protection_policy IdentityDomainsAuthenticationFactorSetting#device_protection_policy}.</summary>
        [JsiiProperty(name: "deviceProtectionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string DeviceProtectionPolicy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#initial_lockout_period_in_secs IdentityDomainsAuthenticationFactorSetting#initial_lockout_period_in_secs}.</summary>
        [JsiiProperty(name: "initialLockoutPeriodInSecs", typeJson: "{\"primitive\":\"number\"}")]
        double InitialLockoutPeriodInSecs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#key_pair_length IdentityDomainsAuthenticationFactorSetting#key_pair_length}.</summary>
        [JsiiProperty(name: "keyPairLength", typeJson: "{\"primitive\":\"number\"}")]
        double KeyPairLength
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#lockout_escalation_pattern IdentityDomainsAuthenticationFactorSetting#lockout_escalation_pattern}.</summary>
        [JsiiProperty(name: "lockoutEscalationPattern", typeJson: "{\"primitive\":\"string\"}")]
        string LockoutEscalationPattern
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#max_failures_before_lockout IdentityDomainsAuthenticationFactorSetting#max_failures_before_lockout}.</summary>
        [JsiiProperty(name: "maxFailuresBeforeLockout", typeJson: "{\"primitive\":\"number\"}")]
        double MaxFailuresBeforeLockout
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#max_failures_before_warning IdentityDomainsAuthenticationFactorSetting#max_failures_before_warning}.</summary>
        [JsiiProperty(name: "maxFailuresBeforeWarning", typeJson: "{\"primitive\":\"number\"}")]
        double MaxFailuresBeforeWarning
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#max_lockout_interval_in_secs IdentityDomainsAuthenticationFactorSetting#max_lockout_interval_in_secs}.</summary>
        [JsiiProperty(name: "maxLockoutIntervalInSecs", typeJson: "{\"primitive\":\"number\"}")]
        double MaxLockoutIntervalInSecs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#min_pin_length IdentityDomainsAuthenticationFactorSetting#min_pin_length}.</summary>
        [JsiiProperty(name: "minPinLength", typeJson: "{\"primitive\":\"number\"}")]
        double MinPinLength
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#policy_update_freq_in_days IdentityDomainsAuthenticationFactorSetting#policy_update_freq_in_days}.</summary>
        [JsiiProperty(name: "policyUpdateFreqInDays", typeJson: "{\"primitive\":\"number\"}")]
        double PolicyUpdateFreqInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#request_signing_algo IdentityDomainsAuthenticationFactorSetting#request_signing_algo}.</summary>
        [JsiiProperty(name: "requestSigningAlgo", typeJson: "{\"primitive\":\"string\"}")]
        string RequestSigningAlgo
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#shared_secret_encoding IdentityDomainsAuthenticationFactorSetting#shared_secret_encoding}.</summary>
        [JsiiProperty(name: "sharedSecretEncoding", typeJson: "{\"primitive\":\"string\"}")]
        string SharedSecretEncoding
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#unlock_app_for_each_request_enabled IdentityDomainsAuthenticationFactorSetting#unlock_app_for_each_request_enabled}.</summary>
        [JsiiProperty(name: "unlockAppForEachRequestEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object UnlockAppForEachRequestEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#unlock_app_interval_in_secs IdentityDomainsAuthenticationFactorSetting#unlock_app_interval_in_secs}.</summary>
        [JsiiProperty(name: "unlockAppIntervalInSecs", typeJson: "{\"primitive\":\"number\"}")]
        double UnlockAppIntervalInSecs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#unlock_on_app_foreground_enabled IdentityDomainsAuthenticationFactorSetting#unlock_on_app_foreground_enabled}.</summary>
        [JsiiProperty(name: "unlockOnAppForegroundEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object UnlockOnAppForegroundEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#unlock_on_app_start_enabled IdentityDomainsAuthenticationFactorSetting#unlock_on_app_start_enabled}.</summary>
        [JsiiProperty(name: "unlockOnAppStartEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object UnlockOnAppStartEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAuthenticationFactorSettingClientAppSettings), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingClientAppSettings")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingClientAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#device_protection_policy IdentityDomainsAuthenticationFactorSetting#device_protection_policy}.</summary>
            [JsiiProperty(name: "deviceProtectionPolicy", typeJson: "{\"primitive\":\"string\"}")]
            public string DeviceProtectionPolicy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#initial_lockout_period_in_secs IdentityDomainsAuthenticationFactorSetting#initial_lockout_period_in_secs}.</summary>
            [JsiiProperty(name: "initialLockoutPeriodInSecs", typeJson: "{\"primitive\":\"number\"}")]
            public double InitialLockoutPeriodInSecs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#key_pair_length IdentityDomainsAuthenticationFactorSetting#key_pair_length}.</summary>
            [JsiiProperty(name: "keyPairLength", typeJson: "{\"primitive\":\"number\"}")]
            public double KeyPairLength
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#lockout_escalation_pattern IdentityDomainsAuthenticationFactorSetting#lockout_escalation_pattern}.</summary>
            [JsiiProperty(name: "lockoutEscalationPattern", typeJson: "{\"primitive\":\"string\"}")]
            public string LockoutEscalationPattern
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#max_failures_before_lockout IdentityDomainsAuthenticationFactorSetting#max_failures_before_lockout}.</summary>
            [JsiiProperty(name: "maxFailuresBeforeLockout", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxFailuresBeforeLockout
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#max_failures_before_warning IdentityDomainsAuthenticationFactorSetting#max_failures_before_warning}.</summary>
            [JsiiProperty(name: "maxFailuresBeforeWarning", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxFailuresBeforeWarning
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#max_lockout_interval_in_secs IdentityDomainsAuthenticationFactorSetting#max_lockout_interval_in_secs}.</summary>
            [JsiiProperty(name: "maxLockoutIntervalInSecs", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxLockoutIntervalInSecs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#min_pin_length IdentityDomainsAuthenticationFactorSetting#min_pin_length}.</summary>
            [JsiiProperty(name: "minPinLength", typeJson: "{\"primitive\":\"number\"}")]
            public double MinPinLength
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#policy_update_freq_in_days IdentityDomainsAuthenticationFactorSetting#policy_update_freq_in_days}.</summary>
            [JsiiProperty(name: "policyUpdateFreqInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double PolicyUpdateFreqInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#request_signing_algo IdentityDomainsAuthenticationFactorSetting#request_signing_algo}.</summary>
            [JsiiProperty(name: "requestSigningAlgo", typeJson: "{\"primitive\":\"string\"}")]
            public string RequestSigningAlgo
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#shared_secret_encoding IdentityDomainsAuthenticationFactorSetting#shared_secret_encoding}.</summary>
            [JsiiProperty(name: "sharedSecretEncoding", typeJson: "{\"primitive\":\"string\"}")]
            public string SharedSecretEncoding
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#unlock_app_for_each_request_enabled IdentityDomainsAuthenticationFactorSetting#unlock_app_for_each_request_enabled}.</summary>
            [JsiiProperty(name: "unlockAppForEachRequestEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object UnlockAppForEachRequestEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#unlock_app_interval_in_secs IdentityDomainsAuthenticationFactorSetting#unlock_app_interval_in_secs}.</summary>
            [JsiiProperty(name: "unlockAppIntervalInSecs", typeJson: "{\"primitive\":\"number\"}")]
            public double UnlockAppIntervalInSecs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#unlock_on_app_foreground_enabled IdentityDomainsAuthenticationFactorSetting#unlock_on_app_foreground_enabled}.</summary>
            [JsiiProperty(name: "unlockOnAppForegroundEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object UnlockOnAppForegroundEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#unlock_on_app_start_enabled IdentityDomainsAuthenticationFactorSetting#unlock_on_app_start_enabled}.</summary>
            [JsiiProperty(name: "unlockOnAppStartEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object UnlockOnAppStartEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
