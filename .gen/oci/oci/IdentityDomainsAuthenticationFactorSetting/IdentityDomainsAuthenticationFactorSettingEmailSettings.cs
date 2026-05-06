using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsAuthenticationFactorSetting
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsAuthenticationFactorSetting.IdentityDomainsAuthenticationFactorSettingEmailSettings")]
    public class IdentityDomainsAuthenticationFactorSettingEmailSettings : oci.IdentityDomainsAuthenticationFactorSetting.IIdentityDomainsAuthenticationFactorSettingEmailSettings
    {
        private object _emailLinkEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#email_link_enabled IdentityDomainsAuthenticationFactorSetting#email_link_enabled}.</summary>
        [JsiiProperty(name: "emailLinkEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object EmailLinkEnabled
        {
            get => _emailLinkEnabled;
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
                _emailLinkEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_authentication_factor_setting#email_link_custom_url IdentityDomainsAuthenticationFactorSetting#email_link_custom_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailLinkCustomUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailLinkCustomUrl
        {
            get;
            set;
        }
    }
}
