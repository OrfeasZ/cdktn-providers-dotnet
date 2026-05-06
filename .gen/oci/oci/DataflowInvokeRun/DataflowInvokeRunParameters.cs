using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowInvokeRun
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataflowInvokeRun.DataflowInvokeRunParameters")]
    public class DataflowInvokeRunParameters : oci.DataflowInvokeRun.IDataflowInvokeRunParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#name DataflowInvokeRun#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#value DataflowInvokeRun#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
