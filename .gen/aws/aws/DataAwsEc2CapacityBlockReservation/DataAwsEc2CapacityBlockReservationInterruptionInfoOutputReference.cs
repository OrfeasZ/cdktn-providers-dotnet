using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2CapacityBlockReservation
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationInterruptionInfoOutputReference), fullyQualifiedName: "aws.dataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationInterruptionInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsEc2CapacityBlockReservationInterruptionInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAwsEc2CapacityBlockReservationInterruptionInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataAwsEc2CapacityBlockReservationInterruptionInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2CapacityBlockReservationInterruptionInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "interruptionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InterruptionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceCapacityReservationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceCapacityReservationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationInterruptionInfo\"}", isOptional: true)]
        public virtual aws.DataAwsEc2CapacityBlockReservation.IDataAwsEc2CapacityBlockReservationInterruptionInfo? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsEc2CapacityBlockReservation.IDataAwsEc2CapacityBlockReservationInterruptionInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
