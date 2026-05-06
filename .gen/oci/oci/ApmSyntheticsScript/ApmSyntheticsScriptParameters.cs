using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsScript
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apmSyntheticsScript.ApmSyntheticsScriptParameters")]
    public class ApmSyntheticsScriptParameters : oci.ApmSyntheticsScript.IApmSyntheticsScriptParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_script#param_name ApmSyntheticsScript#param_name}.</summary>
        [JsiiProperty(name: "paramName", typeJson: "{\"primitive\":\"string\"}")]
        public string ParamName
        {
            get;
            set;
        }

        private object? _isSecret;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_script#is_secret ApmSyntheticsScript#is_secret}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isSecret", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSecret
        {
            get => _isSecret;
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
                _isSecret = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_script#param_value ApmSyntheticsScript#param_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "paramValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParamValue
        {
            get;
            set;
        }
    }
}
