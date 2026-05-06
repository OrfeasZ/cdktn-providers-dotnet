using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthenticationFactorSetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAuthenticationFactorSettingTotpSettings), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingTotpSettings")]
    public interface IIdentityDomainsAuthenticationFactorSettingTotpSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#email_otp_validity_duration_in_mins IdentityDomainsAuthenticationFactorSetting#email_otp_validity_duration_in_mins}.</summary>
        [JsiiProperty(name: "emailOtpValidityDurationInMins", typeJson: "{\"primitive\":\"number\"}")]
        double EmailOtpValidityDurationInMins
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#email_passcode_length IdentityDomainsAuthenticationFactorSetting#email_passcode_length}.</summary>
        [JsiiProperty(name: "emailPasscodeLength", typeJson: "{\"primitive\":\"number\"}")]
        double EmailPasscodeLength
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#hashing_algorithm IdentityDomainsAuthenticationFactorSetting#hashing_algorithm}.</summary>
        [JsiiProperty(name: "hashingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string HashingAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#jwt_validity_duration_in_secs IdentityDomainsAuthenticationFactorSetting#jwt_validity_duration_in_secs}.</summary>
        [JsiiProperty(name: "jwtValidityDurationInSecs", typeJson: "{\"primitive\":\"number\"}")]
        double JwtValidityDurationInSecs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#key_refresh_interval_in_days IdentityDomainsAuthenticationFactorSetting#key_refresh_interval_in_days}.</summary>
        [JsiiProperty(name: "keyRefreshIntervalInDays", typeJson: "{\"primitive\":\"number\"}")]
        double KeyRefreshIntervalInDays
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#passcode_length IdentityDomainsAuthenticationFactorSetting#passcode_length}.</summary>
        [JsiiProperty(name: "passcodeLength", typeJson: "{\"primitive\":\"number\"}")]
        double PasscodeLength
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#sms_otp_validity_duration_in_mins IdentityDomainsAuthenticationFactorSetting#sms_otp_validity_duration_in_mins}.</summary>
        [JsiiProperty(name: "smsOtpValidityDurationInMins", typeJson: "{\"primitive\":\"number\"}")]
        double SmsOtpValidityDurationInMins
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#sms_passcode_length IdentityDomainsAuthenticationFactorSetting#sms_passcode_length}.</summary>
        [JsiiProperty(name: "smsPasscodeLength", typeJson: "{\"primitive\":\"number\"}")]
        double SmsPasscodeLength
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#time_step_in_secs IdentityDomainsAuthenticationFactorSetting#time_step_in_secs}.</summary>
        [JsiiProperty(name: "timeStepInSecs", typeJson: "{\"primitive\":\"number\"}")]
        double TimeStepInSecs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#time_step_tolerance IdentityDomainsAuthenticationFactorSetting#time_step_tolerance}.</summary>
        [JsiiProperty(name: "timeStepTolerance", typeJson: "{\"primitive\":\"number\"}")]
        double TimeStepTolerance
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAuthenticationFactorSettingTotpSettings), fullyQualifiedName: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingTotpSettings")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingTotpSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#email_otp_validity_duration_in_mins IdentityDomainsAuthenticationFactorSetting#email_otp_validity_duration_in_mins}.</summary>
            [JsiiProperty(name: "emailOtpValidityDurationInMins", typeJson: "{\"primitive\":\"number\"}")]
            public double EmailOtpValidityDurationInMins
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#email_passcode_length IdentityDomainsAuthenticationFactorSetting#email_passcode_length}.</summary>
            [JsiiProperty(name: "emailPasscodeLength", typeJson: "{\"primitive\":\"number\"}")]
            public double EmailPasscodeLength
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#hashing_algorithm IdentityDomainsAuthenticationFactorSetting#hashing_algorithm}.</summary>
            [JsiiProperty(name: "hashingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string HashingAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#jwt_validity_duration_in_secs IdentityDomainsAuthenticationFactorSetting#jwt_validity_duration_in_secs}.</summary>
            [JsiiProperty(name: "jwtValidityDurationInSecs", typeJson: "{\"primitive\":\"number\"}")]
            public double JwtValidityDurationInSecs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#key_refresh_interval_in_days IdentityDomainsAuthenticationFactorSetting#key_refresh_interval_in_days}.</summary>
            [JsiiProperty(name: "keyRefreshIntervalInDays", typeJson: "{\"primitive\":\"number\"}")]
            public double KeyRefreshIntervalInDays
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#passcode_length IdentityDomainsAuthenticationFactorSetting#passcode_length}.</summary>
            [JsiiProperty(name: "passcodeLength", typeJson: "{\"primitive\":\"number\"}")]
            public double PasscodeLength
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#sms_otp_validity_duration_in_mins IdentityDomainsAuthenticationFactorSetting#sms_otp_validity_duration_in_mins}.</summary>
            [JsiiProperty(name: "smsOtpValidityDurationInMins", typeJson: "{\"primitive\":\"number\"}")]
            public double SmsOtpValidityDurationInMins
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#sms_passcode_length IdentityDomainsAuthenticationFactorSetting#sms_passcode_length}.</summary>
            [JsiiProperty(name: "smsPasscodeLength", typeJson: "{\"primitive\":\"number\"}")]
            public double SmsPasscodeLength
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#time_step_in_secs IdentityDomainsAuthenticationFactorSetting#time_step_in_secs}.</summary>
            [JsiiProperty(name: "timeStepInSecs", typeJson: "{\"primitive\":\"number\"}")]
            public double TimeStepInSecs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#time_step_tolerance IdentityDomainsAuthenticationFactorSetting#time_step_tolerance}.</summary>
            [JsiiProperty(name: "timeStepTolerance", typeJson: "{\"primitive\":\"number\"}")]
            public double TimeStepTolerance
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
