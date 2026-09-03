using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotFlowRuntime
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.iotIotFlowRuntime.IotIotFlowRuntimeLogConfig")]
    public class IotIotFlowRuntimeLogConfig : oci.IotIotFlowRuntime.IIotIotFlowRuntimeLogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#log_group_id IotIotFlowRuntime#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#log_id IotIotFlowRuntime#log_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogId
        {
            get;
            set;
        }
    }
}
