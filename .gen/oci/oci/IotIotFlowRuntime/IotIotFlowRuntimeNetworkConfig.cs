using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IotIotFlowRuntime
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfig")]
    public class IotIotFlowRuntimeNetworkConfig : oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#subnet_id IotIotFlowRuntime#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }

        private object? _fileStorageMounts;

        /// <summary>file_storage_mounts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#file_storage_mounts IotIotFlowRuntime#file_storage_mounts}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfigFileStorageMounts" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileStorageMounts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.iotIotFlowRuntime.IotIotFlowRuntimeNetworkConfigFileStorageMounts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FileStorageMounts
        {
            get => _fileStorageMounts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfigFileStorageMounts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IotIotFlowRuntime.IIotIotFlowRuntimeNetworkConfigFileStorageMounts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fileStorageMounts = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/iot_iot_flow_runtime#network_security_group_ids IotIotFlowRuntime#network_security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NetworkSecurityGroupIds
        {
            get;
            set;
        }
    }
}
