using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsApplication
{
    [JsiiInterface(nativeType: typeof(IFunctionsApplicationTraceConfig), fullyQualifiedName: "oci.functionsApplication.FunctionsApplicationTraceConfig")]
    public interface IFunctionsApplicationTraceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#domain_id FunctionsApplication#domain_id}.</summary>
        [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#is_enabled FunctionsApplication#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionsApplicationTraceConfig), fullyQualifiedName: "oci.functionsApplication.FunctionsApplicationTraceConfig")]
        internal sealed class _Proxy : DeputyBase, oci.FunctionsApplication.IFunctionsApplicationTraceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#domain_id FunctionsApplication#domain_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_application#is_enabled FunctionsApplication#is_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
