using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowInvokeRun
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataflowInvokeRun.DataflowInvokeRunApplicationLogConfig")]
    public class DataflowInvokeRunApplicationLogConfig : oci.DataflowInvokeRun.IDataflowInvokeRunApplicationLogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#log_group_id DataflowInvokeRun#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_invoke_run#log_id DataflowInvokeRun#log_id}.</summary>
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogId
        {
            get;
            set;
        }
    }
}
