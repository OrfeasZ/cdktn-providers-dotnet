using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotFlowRuntime
{
    [JsiiInterface(nativeType: typeof(IIotIotFlowRuntimeNetworkConfig), fullyQualifiedName: "oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfig")]
    public interface IIotIotFlowRuntimeNetworkConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#subnet_id IotIotFlowRuntime#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>file_storage_mounts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#file_storage_mounts IotIotFlowRuntime#file_storage_mounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfigFileStorageMounts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "fileStorageMounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigFileStorageMounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FileStorageMounts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#network_security_group_ids IotIotFlowRuntime#network_security_group_ids}.</summary>
        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NetworkSecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotIotFlowRuntimeNetworkConfig), fullyQualifiedName: "oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfig")]
        internal sealed class _Proxy : DeputyBase, oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#subnet_id IotIotFlowRuntime#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>file_storage_mounts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#file_storage_mounts IotIotFlowRuntime#file_storage_mounts}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfigFileStorageMounts" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileStorageMounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigFileStorageMounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FileStorageMounts
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#network_security_group_ids IotIotFlowRuntime#network_security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NetworkSecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
