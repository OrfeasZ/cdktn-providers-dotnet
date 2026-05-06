using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthenticationFactorSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingEndpointRestrictions")]
    public class IdentityDomainsAuthenticationFactorSettingEndpointRestrictions : oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingEndpointRestrictions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#max_endpoint_trust_duration_in_days IdentityDomainsAuthenticationFactorSetting#max_endpoint_trust_duration_in_days}.</summary>
        [JsiiProperty(name: "maxEndpointTrustDurationInDays", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxEndpointTrustDurationInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#max_enrolled_devices IdentityDomainsAuthenticationFactorSetting#max_enrolled_devices}.</summary>
        [JsiiProperty(name: "maxEnrolledDevices", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxEnrolledDevices
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#max_incorrect_attempts IdentityDomainsAuthenticationFactorSetting#max_incorrect_attempts}.</summary>
        [JsiiProperty(name: "maxIncorrectAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxIncorrectAttempts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#max_trusted_endpoints IdentityDomainsAuthenticationFactorSetting#max_trusted_endpoints}.</summary>
        [JsiiProperty(name: "maxTrustedEndpoints", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxTrustedEndpoints
        {
            get;
            set;
        }

        private object _trustedEndpointsEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#trusted_endpoints_enabled IdentityDomainsAuthenticationFactorSetting#trusted_endpoints_enabled}.</summary>
        [JsiiProperty(name: "trustedEndpointsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object TrustedEndpointsEnabled
        {
            get => _trustedEndpointsEnabled;
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
                _trustedEndpointsEnabled = value;
            }
        }
    }
}
