using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsApplication
{
    [JsiiInterface(nativeType: typeof(IFunctionsApplicationLogging), fullyQualifiedName: "oci.functionsApplication.FunctionsApplicationLogging")]
    public interface IFunctionsApplicationLogging
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/functions_application#line_format FunctionsApplication#line_format}.</summary>
        [JsiiProperty(name: "lineFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LineFormat
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionsApplicationLogging), fullyQualifiedName: "oci.functionsApplication.FunctionsApplicationLogging")]
        internal sealed class _Proxy : DeputyBase, oci.FunctionsApplication.IFunctionsApplicationLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/functions_application#line_format FunctionsApplication#line_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lineFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LineFormat
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
