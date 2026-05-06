using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigAccessRules")]
    public class WaasWaasPolicyWafConfigAccessRules : oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAccessRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#action WaasWaasPolicy#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        private object _criteria;

        /// <summary>criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#criteria WaasWaasPolicy#criteria}
        /// </remarks>
        [JsiiProperty(name: "criteria", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAccessRulesCriteria\"},\"kind\":\"array\"}}]}}")]
        public object Criteria
        {
            get => _criteria;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAccessRulesCriteria[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAccessRulesCriteria).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAccessRulesCriteria).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _criteria = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#name WaasWaasPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#bypass_challenges WaasWaasPolicy#bypass_challenges}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bypassChallenges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BypassChallenges
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#redirect_response_code WaasWaasPolicy#redirect_response_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectResponseCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedirectResponseCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#redirect_url WaasWaasPolicy#redirect_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedirectUrl
        {
            get;
            set;
        }

        private object? _responseHeaderManipulation;

        /// <summary>response_header_manipulation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#response_header_manipulation WaasWaasPolicy#response_header_manipulation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseHeaderManipulation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.waasWaasPolicy.WaasWaasPolicyWafConfigAccessRulesResponseHeaderManipulation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResponseHeaderManipulation
        {
            get => _responseHeaderManipulation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAccessRulesResponseHeaderManipulation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigAccessRulesResponseHeaderManipulation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _responseHeaderManipulation = value;
            }
        }
    }
}
