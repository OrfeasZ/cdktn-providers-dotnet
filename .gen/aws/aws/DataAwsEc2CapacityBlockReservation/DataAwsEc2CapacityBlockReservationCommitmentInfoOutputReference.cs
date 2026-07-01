using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2CapacityBlockReservation
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationCommitmentInfoOutputReference), fullyQualifiedName: "aws.dataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationCommitmentInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsEc2CapacityBlockReservationCommitmentInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAwsEc2CapacityBlockReservationCommitmentInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataAwsEc2CapacityBlockReservationCommitmentInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2CapacityBlockReservationCommitmentInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "commitmentEndDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommitmentEndDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "committedInstanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CommittedInstanceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsEc2CapacityBlockReservation.DataAwsEc2CapacityBlockReservationCommitmentInfo\"}", isOptional: true)]
        public virtual aws.DataAwsEc2CapacityBlockReservation.IDataAwsEc2CapacityBlockReservationCommitmentInfo? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsEc2CapacityBlockReservation.IDataAwsEc2CapacityBlockReservationCommitmentInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
