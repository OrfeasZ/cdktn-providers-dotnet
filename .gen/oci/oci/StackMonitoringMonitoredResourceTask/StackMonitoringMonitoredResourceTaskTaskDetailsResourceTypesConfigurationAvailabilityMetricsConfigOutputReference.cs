using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceTask
{
    [JsiiClass(nativeType: typeof(oci.StackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfigOutputReference), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCollectionIntervalInSeconds")]
        public virtual void ResetCollectionIntervalInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetrics")]
        public virtual void ResetMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "collectionIntervalInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CollectionIntervalInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? MetricsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "collectionIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CollectionIntervalInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Metrics
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceTask.StackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfig\"}", isOptional: true)]
        public virtual oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfig? InternalValue
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourceTask.IStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationAvailabilityMetricsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
