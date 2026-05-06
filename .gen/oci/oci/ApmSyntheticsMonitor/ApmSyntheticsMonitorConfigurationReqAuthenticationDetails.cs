using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetails")]
    public class ApmSyntheticsMonitorConfigurationReqAuthenticationDetails : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetails
    {
        private object? _authHeaders;

        /// <summary>auth_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#auth_headers ApmSyntheticsMonitor#auth_headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authHeaders", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationReqAuthenticationDetailsAuthHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AuthHeaders
        {
            get => _authHeaders;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetailsAuthHeaders[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationReqAuthenticationDetailsAuthHeaders).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _authHeaders = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#auth_request_method ApmSyntheticsMonitor#auth_request_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authRequestMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthRequestMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#auth_request_post_body ApmSyntheticsMonitor#auth_request_post_body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authRequestPostBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthRequestPostBody
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#auth_token ApmSyntheticsMonitor#auth_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#auth_url ApmSyntheticsMonitor#auth_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#auth_user_name ApmSyntheticsMonitor#auth_user_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthUserName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#auth_user_password ApmSyntheticsMonitor#auth_user_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authUserPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthUserPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#oauth_scheme ApmSyntheticsMonitor#oauth_scheme}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oauthScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OauthScheme
        {
            get;
            set;
        }
    }
}
