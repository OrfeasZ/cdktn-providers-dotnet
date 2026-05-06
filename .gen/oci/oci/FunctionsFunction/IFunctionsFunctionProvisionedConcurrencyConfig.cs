using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    [JsiiInterface(nativeType: typeof(IFunctionsFunctionProvisionedConcurrencyConfig), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionProvisionedConcurrencyConfig")]
    public interface IFunctionsFunctionProvisionedConcurrencyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#strategy FunctionsFunction#strategy}.</summary>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        string Strategy
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#count FunctionsFunction#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Count
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionsFunctionProvisionedConcurrencyConfig), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionProvisionedConcurrencyConfig")]
        internal sealed class _Proxy : DeputyBase, oci.FunctionsFunction.IFunctionsFunctionProvisionedConcurrencyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#strategy FunctionsFunction#strategy}.</summary>
            [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
            public string Strategy
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#count FunctionsFunction#count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
