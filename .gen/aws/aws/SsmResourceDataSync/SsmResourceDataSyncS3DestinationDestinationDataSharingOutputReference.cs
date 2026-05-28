using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmResourceDataSync
{
    [JsiiClass(nativeType: typeof(aws.SsmResourceDataSync.SsmResourceDataSyncS3DestinationDestinationDataSharingOutputReference), fullyQualifiedName: "aws.ssmResourceDataSync.SsmResourceDataSyncS3DestinationDestinationDataSharingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SsmResourceDataSyncS3DestinationDestinationDataSharingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SsmResourceDataSyncS3DestinationDestinationDataSharingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SsmResourceDataSyncS3DestinationDestinationDataSharingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmResourceDataSyncS3DestinationDestinationDataSharingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDestinationDataSharingType")]
        public virtual void ResetDestinationDataSharingType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationDataSharingTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationDataSharingTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "destinationDataSharingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationDataSharingType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ssmResourceDataSync.SsmResourceDataSyncS3DestinationDestinationDataSharing\"}", isOptional: true)]
        public virtual aws.SsmResourceDataSync.ISsmResourceDataSyncS3DestinationDestinationDataSharing? InternalValue
        {
            get => GetInstanceProperty<aws.SsmResourceDataSync.ISsmResourceDataSyncS3DestinationDestinationDataSharing?>();
            set => SetInstanceProperty(value);
        }
    }
}
