using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudBridgeAsset
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetAwsEbsOutputReference), fullyQualifiedName: "oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAssetAwsEbsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudBridgeAssetAwsEbsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudBridgeAssetAwsEbsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudBridgeAssetAwsEbsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudBridgeAssetAwsEbsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attachments", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAssetAwsEbsAttachmentsList\"}")]
        public virtual oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetAwsEbsAttachmentsList Attachments
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetAwsEbsAttachmentsList>()!;
        }

        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Iops
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isEncrypted", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEncrypted
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMultiAttachEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMultiAttachEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sizeInGiBs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SizeInGiBs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAssetAwsEbsTagsList\"}")]
        public virtual oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetAwsEbsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetAwsEbsTagsList>()!;
        }

        [JsiiProperty(name: "throughput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Throughput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "volumeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "volumeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VolumeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAssetAwsEbs\"}", isOptional: true)]
        public virtual oci.DataOciCloudBridgeAsset.IDataOciCloudBridgeAssetAwsEbs? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAsset.IDataOciCloudBridgeAssetAwsEbs?>();
            set => SetInstanceProperty(value);
        }
    }
}
