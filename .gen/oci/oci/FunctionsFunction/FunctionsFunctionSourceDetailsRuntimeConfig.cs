using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.functionsFunction.FunctionsFunctionSourceDetailsRuntimeConfig")]
    public class FunctionsFunctionSourceDetailsRuntimeConfig : oci.FunctionsFunction.IFunctionsFunctionSourceDetailsRuntimeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#functions_runtime_name FunctionsFunction#functions_runtime_name}.</summary>
        [JsiiProperty(name: "functionsRuntimeName", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionsRuntimeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#runtime_config_type FunctionsFunction#runtime_config_type}.</summary>
        [JsiiProperty(name: "runtimeConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public string RuntimeConfigType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#functions_runtime_version_id FunctionsFunction#functions_runtime_version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "functionsRuntimeVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FunctionsRuntimeVersionId
        {
            get;
            set;
        }
    }
}
