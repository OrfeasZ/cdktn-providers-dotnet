using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiByValue(fqn: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigHumanInteractionChallengeChallengeSettings")]
    public class WaasWaasPolicyWafConfigHumanInteractionChallengeChallengeSettings : oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigHumanInteractionChallengeChallengeSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_action WaasWaasPolicy#block_action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_error_page_code WaasWaasPolicy#block_error_page_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockErrorPageCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockErrorPageCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_error_page_description WaasWaasPolicy#block_error_page_description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockErrorPageDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockErrorPageDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_error_page_message WaasWaasPolicy#block_error_page_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockErrorPageMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlockErrorPageMessage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_response_code WaasWaasPolicy#block_response_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockResponseCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BlockResponseCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captcha_footer WaasWaasPolicy#captcha_footer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "captchaFooter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaptchaFooter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captcha_header WaasWaasPolicy#captcha_header}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "captchaHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaptchaHeader
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captcha_submit_label WaasWaasPolicy#captcha_submit_label}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "captchaSubmitLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaptchaSubmitLabel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captcha_title WaasWaasPolicy#captcha_title}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "captchaTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaptchaTitle
        {
            get;
            set;
        }
    }
}
