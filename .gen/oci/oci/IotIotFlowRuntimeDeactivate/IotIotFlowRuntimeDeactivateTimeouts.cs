using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotFlowRuntimeDeactivate
{
    [JsiiByValue(fqn: "oci.iotIotFlowRuntimeDeactivate.IotIotFlowRuntimeDeactivateTimeouts")]
    public class IotIotFlowRuntimeDeactivateTimeouts : oci.IotIotFlowRuntimeDeactivate.IIotIotFlowRuntimeDeactivateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime_deactivate#create IotIotFlowRuntimeDeactivate#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime_deactivate#delete IotIotFlowRuntimeDeactivate#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime_deactivate#update IotIotFlowRuntimeDeactivate#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
