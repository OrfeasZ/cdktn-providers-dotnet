using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiInterface(nativeType: typeof(IWaasWaasPolicyWafConfigCaptchas), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigCaptchas")]
    public interface IWaasWaasPolicyWafConfigCaptchas
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#failure_message WaasWaasPolicy#failure_message}.</summary>
        [JsiiProperty(name: "failureMessage", typeJson: "{\"primitive\":\"string\"}")]
        string FailureMessage
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#session_expiration_in_seconds WaasWaasPolicy#session_expiration_in_seconds}.</summary>
        [JsiiProperty(name: "sessionExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double SessionExpirationInSeconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#submit_label WaasWaasPolicy#submit_label}.</summary>
        [JsiiProperty(name: "submitLabel", typeJson: "{\"primitive\":\"string\"}")]
        string SubmitLabel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#title WaasWaasPolicy#title}.</summary>
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        string Title
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#url WaasWaasPolicy#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#footer_text WaasWaasPolicy#footer_text}.</summary>
        [JsiiProperty(name: "footerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FooterText
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#header_text WaasWaasPolicy#header_text}.</summary>
        [JsiiProperty(name: "headerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HeaderText
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWaasWaasPolicyWafConfigCaptchas), fullyQualifiedName: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigCaptchas")]
        internal sealed class _Proxy : DeputyBase, oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigCaptchas
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#failure_message WaasWaasPolicy#failure_message}.</summary>
            [JsiiProperty(name: "failureMessage", typeJson: "{\"primitive\":\"string\"}")]
            public string FailureMessage
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#session_expiration_in_seconds WaasWaasPolicy#session_expiration_in_seconds}.</summary>
            [JsiiProperty(name: "sessionExpirationInSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double SessionExpirationInSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#submit_label WaasWaasPolicy#submit_label}.</summary>
            [JsiiProperty(name: "submitLabel", typeJson: "{\"primitive\":\"string\"}")]
            public string SubmitLabel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#title WaasWaasPolicy#title}.</summary>
            [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
            public string Title
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#url WaasWaasPolicy#url}.</summary>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#footer_text WaasWaasPolicy#footer_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "footerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FooterText
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#header_text WaasWaasPolicy#header_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "headerText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HeaderText
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
