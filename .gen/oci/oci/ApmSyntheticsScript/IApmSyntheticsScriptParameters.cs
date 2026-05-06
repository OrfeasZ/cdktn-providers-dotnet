using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsScript
{
    [JsiiInterface(nativeType: typeof(IApmSyntheticsScriptParameters), fullyQualifiedName: "oci.apmSyntheticsScript.ApmSyntheticsScriptParameters")]
    public interface IApmSyntheticsScriptParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_script#param_name ApmSyntheticsScript#param_name}.</summary>
        [JsiiProperty(name: "paramName", typeJson: "{\"primitive\":\"string\"}")]
        string ParamName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_script#is_secret ApmSyntheticsScript#is_secret}.</summary>
        [JsiiProperty(name: "isSecret", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_script#param_value ApmSyntheticsScript#param_value}.</summary>
        [JsiiProperty(name: "paramValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParamValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmSyntheticsScriptParameters), fullyQualifiedName: "oci.apmSyntheticsScript.ApmSyntheticsScriptParameters")]
        internal sealed class _Proxy : DeputyBase, oci.ApmSyntheticsScript.IApmSyntheticsScriptParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_script#param_name ApmSyntheticsScript#param_name}.</summary>
            [JsiiProperty(name: "paramName", typeJson: "{\"primitive\":\"string\"}")]
            public string ParamName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_script#is_secret ApmSyntheticsScript#is_secret}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSecret", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSecret
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_script#param_value ApmSyntheticsScript#param_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "paramValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParamValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
