using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsApplication
{
    [JsiiByValue(fqn: "oci.functionsApplication.FunctionsApplicationLogging")]
    public class FunctionsApplicationLogging : oci.FunctionsApplication.IFunctionsApplicationLogging
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/functions_application#line_format FunctionsApplication#line_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lineFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LineFormat
        {
            get;
            set;
        }
    }
}
