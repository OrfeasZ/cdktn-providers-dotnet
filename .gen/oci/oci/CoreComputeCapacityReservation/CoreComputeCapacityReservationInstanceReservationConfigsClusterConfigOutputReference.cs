using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCapacityReservation
{
    [JsiiClass(nativeType: typeof(oci.CoreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsClusterConfigOutputReference), fullyQualifiedName: "oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsClusterConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreComputeCapacityReservationInstanceReservationConfigsClusterConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreComputeCapacityReservationInstanceReservationConfigsClusterConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreComputeCapacityReservationInstanceReservationConfigsClusterConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreComputeCapacityReservationInstanceReservationConfigsClusterConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetNetworkBlockIds")]
        public virtual void ResetNetworkBlockIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "hpcIslandIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HpcIslandIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkBlockIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NetworkBlockIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "hpcIslandId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HpcIslandId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkBlockIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NetworkBlockIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreComputeCapacityReservation.CoreComputeCapacityReservationInstanceReservationConfigsClusterConfig\"}", isOptional: true)]
        public virtual oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigsClusterConfig? InternalValue
        {
            get => GetInstanceProperty<oci.CoreComputeCapacityReservation.ICoreComputeCapacityReservationInstanceReservationConfigsClusterConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
