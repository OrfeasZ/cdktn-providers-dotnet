using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigCaptchas")]
    public class WaasWaasPolicyWafConfigCaptchas : oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCaptchas
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#failure_message WaasWaasPolicy#failure_message}.</summary>
        [JsiiProperty(name: "failureMessage", typeJson: "{\"primitive\":\"string\"}")]
        public string FailureMessage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#session_expiration_in_seconds WaasWaasPolicy#session_expiration_in_seconds}.</summary>
        [JsiiProperty(name: "sessionExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double SessionExpirationInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#submit_label WaasWaasPolicy#submit_label}.</summary>
        [JsiiProperty(name: "submitLabel", typeJson: "{\"primitive\":\"string\"}")]
        public string SubmitLabel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#title WaasWaasPolicy#title}.</summary>
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public string Title
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#url WaasWaasPolicy#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#footer_text WaasWaasPolicy#footer_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "footerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FooterText
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#header_text WaasWaasPolicy#header_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HeaderText
        {
            get;
            set;
        }
    }
}
