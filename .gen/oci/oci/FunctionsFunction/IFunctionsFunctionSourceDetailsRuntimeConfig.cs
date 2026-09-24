using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    [JsiiInterface(nativeType: typeof(IFunctionsFunctionSourceDetailsRuntimeConfig), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionSourceDetailsRuntimeConfig")]
    public interface IFunctionsFunctionSourceDetailsRuntimeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#functions_runtime_name FunctionsFunction#functions_runtime_name}.</summary>
        [JsiiProperty(name: "functionsRuntimeName", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionsRuntimeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#runtime_config_type FunctionsFunction#runtime_config_type}.</summary>
        [JsiiProperty(name: "runtimeConfigType", typeJson: "{\"primitive\":\"string\"}")]
        string RuntimeConfigType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#functions_runtime_version_id FunctionsFunction#functions_runtime_version_id}.</summary>
        [JsiiProperty(name: "functionsRuntimeVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FunctionsRuntimeVersionId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionsFunctionSourceDetailsRuntimeConfig), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionSourceDetailsRuntimeConfig")]
        internal sealed class _Proxy : DeputyBase, oci.FunctionsFunction.IFunctionsFunctionSourceDetailsRuntimeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#functions_runtime_name FunctionsFunction#functions_runtime_name}.</summary>
            [JsiiProperty(name: "functionsRuntimeName", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionsRuntimeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#runtime_config_type FunctionsFunction#runtime_config_type}.</summary>
            [JsiiProperty(name: "runtimeConfigType", typeJson: "{\"primitive\":\"string\"}")]
            public string RuntimeConfigType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.3.0/docs/resources/functions_function#functions_runtime_version_id FunctionsFunction#functions_runtime_version_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "functionsRuntimeVersionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FunctionsRuntimeVersionId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
