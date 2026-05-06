using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NosqlTable
{
    [JsiiClass(nativeType: typeof(oci.NosqlTable.NosqlTableTableLimitsOutputReference), fullyQualifiedName: "oci.nosqlTable.NosqlTableTableLimitsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NosqlTableTableLimitsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NosqlTableTableLimitsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected NosqlTableTableLimitsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NosqlTableTableLimitsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCapacityMode")]
        public virtual void ResetCapacityMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CapacityModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxReadUnitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxReadUnitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxStorageInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxStorageInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxWriteUnitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxWriteUnitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "capacityMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CapacityMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxReadUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxReadUnits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxWriteUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxWriteUnits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.nosqlTable.NosqlTableTableLimits\"}", isOptional: true)]
        public virtual oci.NosqlTable.INosqlTableTableLimits? InternalValue
        {
            get => GetInstanceProperty<oci.NosqlTable.INosqlTableTableLimits?>();
            set => SetInstanceProperty(value);
        }
    }
}
