using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SchServiceConnector
{
    [JsiiInterface(nativeType: typeof(ISchServiceConnectorTarget), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorTarget")]
    public interface ISchServiceConnectorTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#kind SchServiceConnector#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_rollover_size_in_mbs SchServiceConnector#batch_rollover_size_in_mbs}.</summary>
        [JsiiProperty(name: "batchRolloverSizeInMbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchRolloverSizeInMbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_rollover_time_in_ms SchServiceConnector#batch_rollover_time_in_ms}.</summary>
        [JsiiProperty(name: "batchRolloverTimeInMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchRolloverTimeInMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_size_in_kbs SchServiceConnector#batch_size_in_kbs}.</summary>
        [JsiiProperty(name: "batchSizeInKbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchSizeInKbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_size_in_num SchServiceConnector#batch_size_in_num}.</summary>
        [JsiiProperty(name: "batchSizeInNum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchSizeInNum
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_time_in_sec SchServiceConnector#batch_time_in_sec}.</summary>
        [JsiiProperty(name: "batchTimeInSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BatchTimeInSec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#bucket SchServiceConnector#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Bucket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#compartment_id SchServiceConnector#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>dimensions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#dimensions SchServiceConnector#dimensions}
        /// </remarks>
        [JsiiProperty(name: "dimensions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorTargetDimensions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Dimensions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#enable_formatted_messaging SchServiceConnector#enable_formatted_messaging}.</summary>
        [JsiiProperty(name: "enableFormattedMessaging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableFormattedMessaging
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#function_id SchServiceConnector#function_id}.</summary>
        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FunctionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_group_id SchServiceConnector#log_group_id}.</summary>
        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_source_identifier SchServiceConnector#log_source_identifier}.</summary>
        [JsiiProperty(name: "logSourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogSourceIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#metric SchServiceConnector#metric}.</summary>
        [JsiiProperty(name: "metric", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Metric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#metric_namespace SchServiceConnector#metric_namespace}.</summary>
        [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricNamespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#namespace SchServiceConnector#namespace}.</summary>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#object_name_prefix SchServiceConnector#object_name_prefix}.</summary>
        [JsiiProperty(name: "objectNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectNamePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#stream_id SchServiceConnector#stream_id}.</summary>
        [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#topic_id SchServiceConnector#topic_id}.</summary>
        [JsiiProperty(name: "topicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TopicId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISchServiceConnectorTarget), fullyQualifiedName: "oci.schServiceConnector.SchServiceConnectorTarget")]
        internal sealed class _Proxy : DeputyBase, oci.SchServiceConnector.ISchServiceConnectorTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#kind SchServiceConnector#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_rollover_size_in_mbs SchServiceConnector#batch_rollover_size_in_mbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchRolloverSizeInMbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchRolloverSizeInMbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_rollover_time_in_ms SchServiceConnector#batch_rollover_time_in_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchRolloverTimeInMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchRolloverTimeInMs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_size_in_kbs SchServiceConnector#batch_size_in_kbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchSizeInKbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchSizeInKbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_size_in_num SchServiceConnector#batch_size_in_num}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchSizeInNum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchSizeInNum
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#batch_time_in_sec SchServiceConnector#batch_time_in_sec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchTimeInSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BatchTimeInSec
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#bucket SchServiceConnector#bucket}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Bucket
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#compartment_id SchServiceConnector#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dimensions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#dimensions SchServiceConnector#dimensions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dimensions", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.schServiceConnector.SchServiceConnectorTargetDimensions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Dimensions
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#enable_formatted_messaging SchServiceConnector#enable_formatted_messaging}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableFormattedMessaging", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableFormattedMessaging
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#function_id SchServiceConnector#function_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FunctionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_group_id SchServiceConnector#log_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#log_source_identifier SchServiceConnector#log_source_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logSourceIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogSourceIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#metric SchServiceConnector#metric}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metric", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Metric
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#metric_namespace SchServiceConnector#metric_namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricNamespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#namespace SchServiceConnector#namespace}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#object_name_prefix SchServiceConnector#object_name_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectNamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectNamePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#stream_id SchServiceConnector#stream_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/sch_service_connector#topic_id SchServiceConnector#topic_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "topicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TopicId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
