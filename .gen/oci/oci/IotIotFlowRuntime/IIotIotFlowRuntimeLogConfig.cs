using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotFlowRuntime
{
    [JsiiInterface(nativeType: typeof(IIotIotFlowRuntimeLogConfig), fullyQualifiedName: "oci.iotIotFlowRuntime.IotIotFlowRuntimeLogConfig")]
    public interface IIotIotFlowRuntimeLogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#log_group_id IotIotFlowRuntime#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#log_id IotIotFlowRuntime#log_id}.</summary>
        [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotIotFlowRuntimeLogConfig), fullyQualifiedName: "oci.iotIotFlowRuntime.IotIotFlowRuntimeLogConfig")]
        internal sealed class _Proxy : DeputyBase, oci.IotIotFlowRuntime.IIotIotFlowRuntimeLogConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#log_group_id IotIotFlowRuntime#log_group_id}.</summary>
            [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#log_id IotIotFlowRuntime#log_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
