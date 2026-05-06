using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreInstanceConfigurations
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsLaunchDetailsSourceDetailsOutputReference), fullyQualifiedName: "oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsLaunchDetailsSourceDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsLaunchDetailsSourceDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsLaunchDetailsSourceDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsLaunchDetailsSourceDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsLaunchDetailsSourceDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bootVolumeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootVolumeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootVolumeSizeInGbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootVolumeSizeInGbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bootVolumeVpusPerGb", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootVolumeVpusPerGb
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceSourceImageFilterDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsLaunchDetailsSourceDetailsInstanceSourceImageFilterDetailsList\"}")]
        public virtual oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsLaunchDetailsSourceDetailsInstanceSourceImageFilterDetailsList InstanceSourceImageFilterDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsLaunchDetailsSourceDetailsInstanceSourceImageFilterDetailsList>()!;
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceConfigurations.DataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsLaunchDetailsSourceDetails\"}", isOptional: true)]
        public virtual oci.DataOciCoreInstanceConfigurations.IDataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsLaunchDetailsSourceDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceConfigurations.IDataOciCoreInstanceConfigurationsInstanceConfigurationsInstanceDetailsLaunchDetailsSourceDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
