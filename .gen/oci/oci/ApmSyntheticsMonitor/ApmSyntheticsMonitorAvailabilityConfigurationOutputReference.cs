using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiClass(nativeType: typeof(oci.ApmSyntheticsMonitor.ApmSyntheticsMonitorAvailabilityConfigurationOutputReference), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorAvailabilityConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApmSyntheticsMonitorAvailabilityConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApmSyntheticsMonitorAvailabilityConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApmSyntheticsMonitorAvailabilityConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmSyntheticsMonitorAvailabilityConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxAllowedFailuresPerInterval")]
        public virtual void ResetMaxAllowedFailuresPerInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinAllowedRunsPerInterval")]
        public virtual void ResetMinAllowedRunsPerInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxAllowedFailuresPerIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxAllowedFailuresPerIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minAllowedRunsPerIntervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinAllowedRunsPerIntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxAllowedFailuresPerInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAllowedFailuresPerInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minAllowedRunsPerInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinAllowedRunsPerInterval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorAvailabilityConfiguration\"}", isOptional: true)]
        public virtual oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorAvailabilityConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorAvailabilityConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
