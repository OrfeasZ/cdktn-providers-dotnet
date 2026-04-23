using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerMonitoringSchedule
{
    [JsiiInterface(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfig), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfig")]
    public interface ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#enable_inter_container_traffic_encryption SagemakerMonitoringSchedule#enable_inter_container_traffic_encryption}.</summary>
        [JsiiProperty(name: "enableInterContainerTrafficEncryption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableInterContainerTrafficEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#enable_network_isolation SagemakerMonitoringSchedule#enable_network_isolation}.</summary>
        [JsiiProperty(name: "enableNetworkIsolation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableNetworkIsolation
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#vpc_config SagemakerMonitoringSchedule#vpc_config}
        /// </remarks>
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfigVpcConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfigVpcConfig? VpcConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfig), fullyQualifiedName: "aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#enable_inter_container_traffic_encryption SagemakerMonitoringSchedule#enable_inter_container_traffic_encryption}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableInterContainerTrafficEncryption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableInterContainerTrafficEncryption
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#enable_network_isolation SagemakerMonitoringSchedule#enable_network_isolation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableNetworkIsolation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableNetworkIsolation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>vpc_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_monitoring_schedule#vpc_config SagemakerMonitoringSchedule#vpc_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.sagemakerMonitoringSchedule.SagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfigVpcConfig\"}", isOptional: true)]
            public aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfigVpcConfig? VpcConfig
            {
                get => GetInstanceProperty<aws.SagemakerMonitoringSchedule.ISagemakerMonitoringScheduleMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfigVpcConfig?>();
            }
        }
    }
}
