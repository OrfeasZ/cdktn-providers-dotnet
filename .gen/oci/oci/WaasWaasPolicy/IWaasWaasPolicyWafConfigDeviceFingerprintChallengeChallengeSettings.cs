using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings")]
    public interface IWaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_action WaasWaasPolicy#block_action}.</summary>
        [JsiiProperty(name: "blockAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlockAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_error_page_code WaasWaasPolicy#block_error_page_code}.</summary>
        [JsiiProperty(name: "blockErrorPageCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlockErrorPageCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_error_page_description WaasWaasPolicy#block_error_page_description}.</summary>
        [JsiiProperty(name: "blockErrorPageDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlockErrorPageDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_error_page_message WaasWaasPolicy#block_error_page_message}.</summary>
        [JsiiProperty(name: "blockErrorPageMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BlockErrorPageMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_response_code WaasWaasPolicy#block_response_code}.</summary>
        [JsiiProperty(name: "blockResponseCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BlockResponseCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captcha_footer WaasWaasPolicy#captcha_footer}.</summary>
        [JsiiProperty(name: "captchaFooter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaptchaFooter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captcha_header WaasWaasPolicy#captcha_header}.</summary>
        [JsiiProperty(name: "captchaHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaptchaHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captcha_submit_label WaasWaasPolicy#captcha_submit_label}.</summary>
        [JsiiProperty(name: "captchaSubmitLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaptchaSubmitLabel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captcha_title WaasWaasPolicy#captcha_title}.</summary>
        [JsiiProperty(name: "captchaTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaptchaTitle
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigDeviceFingerprintChallengeChallengeSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_action WaasWaasPolicy#block_action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlockAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_error_page_code WaasWaasPolicy#block_error_page_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockErrorPageCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlockErrorPageCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_error_page_description WaasWaasPolicy#block_error_page_description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockErrorPageDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlockErrorPageDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_error_page_message WaasWaasPolicy#block_error_page_message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockErrorPageMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BlockErrorPageMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#block_response_code WaasWaasPolicy#block_response_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "blockResponseCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BlockResponseCode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captcha_footer WaasWaasPolicy#captcha_footer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "captchaFooter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaptchaFooter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captcha_header WaasWaasPolicy#captcha_header}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "captchaHeader", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaptchaHeader
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captcha_submit_label WaasWaasPolicy#captcha_submit_label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "captchaSubmitLabel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaptchaSubmitLabel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#captcha_title WaasWaasPolicy#captcha_title}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "captchaTitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaptchaTitle
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
