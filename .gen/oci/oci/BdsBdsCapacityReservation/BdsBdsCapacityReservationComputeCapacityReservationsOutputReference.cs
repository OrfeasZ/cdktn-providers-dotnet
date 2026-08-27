using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsCapacityReservation
{
    [JsiiClass(nativeType: typeof(oci.BdsBdsCapacityReservation.BdsBdsCapacityReservationComputeCapacityReservationsOutputReference), fullyQualifiedName: "oci.bdsBdsCapacityReservation.BdsBdsCapacityReservationComputeCapacityReservationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BdsBdsCapacityReservationComputeCapacityReservationsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BdsBdsCapacityReservationComputeCapacityReservationsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BdsBdsCapacityReservationComputeCapacityReservationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsBdsCapacityReservationComputeCapacityReservationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDomain1ReservationId")]
        public virtual void ResetDomain1ReservationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomain2ReservationId")]
        public virtual void ResetDomain2ReservationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDomain3ReservationId")]
        public virtual void ResetDomain3ReservationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "domain1ReservationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Domain1ReservationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domain2ReservationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Domain2ReservationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domain3ReservationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Domain3ReservationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "domain1ReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain1ReservationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domain2ReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain2ReservationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domain3ReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain3ReservationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.bdsBdsCapacityReservation.BdsBdsCapacityReservationComputeCapacityReservations\"}", isOptional: true)]
        public virtual oci.BdsBdsCapacityReservation.IBdsBdsCapacityReservationComputeCapacityReservations? InternalValue
        {
            get => GetInstanceProperty<oci.BdsBdsCapacityReservation.IBdsBdsCapacityReservationComputeCapacityReservations?>();
            set => SetInstanceProperty(value);
        }
    }
}
