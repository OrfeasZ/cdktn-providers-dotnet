using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotFlowRuntime
{
    [JsiiByValue(fqn: "oci.iotIotFlowRuntime.IotIotFlowRuntimeTimeouts")]
    public class IotIotFlowRuntimeTimeouts : oci.IotIotFlowRuntime.IIotIotFlowRuntimeTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#create IotIotFlowRuntime#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#delete IotIotFlowRuntime#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#update IotIotFlowRuntime#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
