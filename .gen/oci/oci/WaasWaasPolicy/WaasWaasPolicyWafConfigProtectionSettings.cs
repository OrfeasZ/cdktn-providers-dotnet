using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WaasWaasPolicy
{
    [JsiiByValue(fqn: "oci.waasWaasPolicy.WaasWaasPolicyWafConfigProtectionSettings")]
    public class WaasWaasPolicyWafConfigProtectionSettings : oci.WaasWaasPolicy.IWaasWaasPolicyWafConfigProtectionSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#allowed_http_methods WaasWaasPolicy#allowed_http_methods}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedHttpMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedHttpMethods
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

        private object? _isResponseInspected;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#is_response_inspected WaasWaasPolicy#is_response_inspected}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isResponseInspected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsResponseInspected
        {
            get => _isResponseInspected;
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
                _isResponseInspected = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#max_argument_count WaasWaasPolicy#max_argument_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxArgumentCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxArgumentCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#max_name_length_per_argument WaasWaasPolicy#max_name_length_per_argument}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxNameLengthPerArgument", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxNameLengthPerArgument
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#max_response_size_in_ki_b WaasWaasPolicy#max_response_size_in_ki_b}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxResponseSizeInKiB", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxResponseSizeInKiB
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#max_total_name_length_of_arguments WaasWaasPolicy#max_total_name_length_of_arguments}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxTotalNameLengthOfArguments", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxTotalNameLengthOfArguments
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#media_types WaasWaasPolicy#media_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mediaTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? MediaTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/waas_waas_policy#recommendations_period_in_days WaasWaasPolicy#recommendations_period_in_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recommendationsPeriodInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RecommendationsPeriodInDays
        {
            get;
            set;
        }
    }
}
