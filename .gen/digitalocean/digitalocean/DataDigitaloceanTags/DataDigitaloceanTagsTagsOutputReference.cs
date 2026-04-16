using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanTags
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanTags.DataDigitaloceanTagsTagsOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanTags.DataDigitaloceanTagsTagsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanTagsTagsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanTagsTagsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanTagsTagsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanTagsTagsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "databasesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DatabasesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dropletsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DropletsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "imagesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ImagesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalResourceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalResourceCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "volumesCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VolumesCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "volumeSnapshotsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VolumeSnapshotsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanTags.DataDigitaloceanTagsTags\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanTags.IDataDigitaloceanTagsTags? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanTags.IDataDigitaloceanTagsTags?>();
            set => SetInstanceProperty(value);
        }
    }
}
