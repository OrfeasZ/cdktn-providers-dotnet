using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.functionsFunction.FunctionsFunctionProvisionedConcurrencyConfig")]
    public class FunctionsFunctionProvisionedConcurrencyConfig : oci.FunctionsFunction.IFunctionsFunctionProvisionedConcurrencyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#strategy FunctionsFunction#strategy}.</summary>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        public string Strategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/functions_function#count FunctionsFunction#count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Count
        {
            get;
            set;
        }
    }
}
