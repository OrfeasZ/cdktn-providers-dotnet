using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCapacityReservation
{
    [JsiiClass(nativeType: typeof(oci.CoreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfigOutputReference), fullyQualifiedName: "oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMemoryInGbs")]
        public virtual void ResetMemoryInGbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcpus")]
        public virtual void ResetOcpus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemoryInGbsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ocpusInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OcpusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryInGbs
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ocpus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfig\"}", isOptional: true)]
        public virtual oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfig? InternalValue
        {
            get => GetInstanceProperty<oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigsInstanceShapeConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
