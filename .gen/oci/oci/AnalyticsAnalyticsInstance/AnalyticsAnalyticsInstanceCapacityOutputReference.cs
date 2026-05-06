using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AnalyticsAnalyticsInstance
{
    [JsiiClass(nativeType: typeof(oci.AnalyticsAnalyticsInstance.AnalyticsAnalyticsInstanceCapacityOutputReference), fullyQualifiedName: "oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceCapacityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AnalyticsAnalyticsInstanceCapacityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AnalyticsAnalyticsInstanceCapacityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AnalyticsAnalyticsInstanceCapacityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AnalyticsAnalyticsInstanceCapacityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityValueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CapacityValueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "capacityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "capacityValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CapacityValue
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.analyticsAnalyticsInstance.AnalyticsAnalyticsInstanceCapacity\"}", isOptional: true)]
        public virtual oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceCapacity? InternalValue
        {
            get => GetInstanceProperty<oci.AnalyticsAnalyticsInstance.IAnalyticsAnalyticsInstanceCapacity?>();
            set => SetInstanceProperty(value);
        }
    }
}
