using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiByValue(fqn: "oci.waasWaasPolicy.WaasWaasPolicyPolicyConfigHealthChecks")]
    public class WaasWaasPolicyPolicyConfigHealthChecks : oci.WaasWaasPolicy.IWaasWaasPolicyPolicyConfigHealthChecks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#expected_response_code_group WaasWaasPolicy#expected_response_code_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expectedResponseCodeGroup", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExpectedResponseCodeGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#expected_response_text WaasWaasPolicy#expected_response_text}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expectedResponseText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExpectedResponseText
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#headers WaasWaasPolicy#headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Headers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#healthy_threshold WaasWaasPolicy#healthy_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthyThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#interval_in_seconds WaasWaasPolicy#interval_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intervalInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalInSeconds
        {
            get;
            set;
        }

        private object? _isEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_enabled WaasWaasPolicy#is_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsEnabled
        {
            get => _isEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isEnabled = value;
            }
        }

        private object? _isResponseTextCheckEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_response_text_check_enabled WaasWaasPolicy#is_response_text_check_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isResponseTextCheckEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsResponseTextCheckEnabled
        {
            get => _isResponseTextCheckEnabled;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isResponseTextCheckEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#method WaasWaasPolicy#method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Method
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#path WaasWaasPolicy#path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#timeout_in_seconds WaasWaasPolicy#timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#unhealthy_threshold WaasWaasPolicy#unhealthy_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnhealthyThreshold
        {
            get;
            set;
        }
    }
}
