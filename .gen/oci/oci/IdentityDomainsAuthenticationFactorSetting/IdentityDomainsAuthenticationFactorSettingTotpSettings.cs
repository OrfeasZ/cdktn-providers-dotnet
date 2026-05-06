using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthenticationFactorSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingTotpSettings")]
    public class IdentityDomainsAuthenticationFactorSettingTotpSettings : oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingTotpSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#email_otp_validity_duration_in_mins IdentityDomainsAuthenticationFactorSetting#email_otp_validity_duration_in_mins}.</summary>
        [JsiiProperty(name: "emailOtpValidityDurationInMins", typeJson: "{\"primitive\":\"number\"}")]
        public double EmailOtpValidityDurationInMins
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#email_passcode_length IdentityDomainsAuthenticationFactorSetting#email_passcode_length}.</summary>
        [JsiiProperty(name: "emailPasscodeLength", typeJson: "{\"primitive\":\"number\"}")]
        public double EmailPasscodeLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#hashing_algorithm IdentityDomainsAuthenticationFactorSetting#hashing_algorithm}.</summary>
        [JsiiProperty(name: "hashingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string HashingAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#jwt_validity_duration_in_secs IdentityDomainsAuthenticationFactorSetting#jwt_validity_duration_in_secs}.</summary>
        [JsiiProperty(name: "jwtValidityDurationInSecs", typeJson: "{\"primitive\":\"number\"}")]
        public double JwtValidityDurationInSecs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#key_refresh_interval_in_days IdentityDomainsAuthenticationFactorSetting#key_refresh_interval_in_days}.</summary>
        [JsiiProperty(name: "keyRefreshIntervalInDays", typeJson: "{\"primitive\":\"number\"}")]
        public double KeyRefreshIntervalInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#passcode_length IdentityDomainsAuthenticationFactorSetting#passcode_length}.</summary>
        [JsiiProperty(name: "passcodeLength", typeJson: "{\"primitive\":\"number\"}")]
        public double PasscodeLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#sms_otp_validity_duration_in_mins IdentityDomainsAuthenticationFactorSetting#sms_otp_validity_duration_in_mins}.</summary>
        [JsiiProperty(name: "smsOtpValidityDurationInMins", typeJson: "{\"primitive\":\"number\"}")]
        public double SmsOtpValidityDurationInMins
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#sms_passcode_length IdentityDomainsAuthenticationFactorSetting#sms_passcode_length}.</summary>
        [JsiiProperty(name: "smsPasscodeLength", typeJson: "{\"primitive\":\"number\"}")]
        public double SmsPasscodeLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#time_step_in_secs IdentityDomainsAuthenticationFactorSetting#time_step_in_secs}.</summary>
        [JsiiProperty(name: "timeStepInSecs", typeJson: "{\"primitive\":\"number\"}")]
        public double TimeStepInSecs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#time_step_tolerance IdentityDomainsAuthenticationFactorSetting#time_step_tolerance}.</summary>
        [JsiiProperty(name: "timeStepTolerance", typeJson: "{\"primitive\":\"number\"}")]
        public double TimeStepTolerance
        {
            get;
            set;
        }
    }
}
