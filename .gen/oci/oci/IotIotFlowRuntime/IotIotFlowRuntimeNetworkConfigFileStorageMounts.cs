using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotFlowRuntime
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigFileStorageMounts")]
    public class IotIotFlowRuntimeNetworkConfigFileStorageMounts : oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfigFileStorageMounts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#export_id IotIotFlowRuntime#export_id}.</summary>
        [JsiiProperty(name: "exportId", typeJson: "{\"primitive\":\"string\"}")]
        public string ExportId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#mount_path IotIotFlowRuntime#mount_path}.</summary>
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}")]
        public string MountPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#mount_target_id IotIotFlowRuntime#mount_target_id}.</summary>
        [JsiiProperty(name: "mountTargetId", typeJson: "{\"primitive\":\"string\"}")]
        public string MountTargetId
        {
            get;
            set;
        }
    }
}
