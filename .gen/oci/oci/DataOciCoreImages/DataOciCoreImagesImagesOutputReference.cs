using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreImages
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreImages.DataOciCoreImagesImagesOutputReference), fullyQualifiedName: "oci.dataOciCoreImages.DataOciCoreImagesImagesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreImagesImagesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreImagesImagesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreImagesImagesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreImagesImagesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentFeatures", typeJson: "{\"fqn\":\"oci.dataOciCoreImages.DataOciCoreImagesImagesAgentFeaturesList\"}")]
        public virtual oci.DataOciCoreImages.DataOciCoreImagesImagesAgentFeaturesList AgentFeatures
        {
            get => GetInstanceProperty<oci.DataOciCoreImages.DataOciCoreImagesImagesAgentFeaturesList>()!;
        }

        [JsiiProperty(name: "baseImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BaseImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billableSizeInGbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillableSizeInGbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createImageAllowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CreateImageAllowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageSourceDetails", typeJson: "{\"fqn\":\"oci.dataOciCoreImages.DataOciCoreImagesImagesImageSourceDetailsList\"}")]
        public virtual oci.DataOciCoreImages.DataOciCoreImagesImagesImageSourceDetailsList ImageSourceDetails
        {
            get => GetInstanceProperty<oci.DataOciCoreImages.DataOciCoreImagesImagesImageSourceDetailsList>()!;
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "launchMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LaunchMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "launchOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreImages.DataOciCoreImagesImagesLaunchOptionsList\"}")]
        public virtual oci.DataOciCoreImages.DataOciCoreImagesImagesLaunchOptionsList LaunchOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreImages.DataOciCoreImagesImagesLaunchOptionsList>()!;
        }

        [JsiiProperty(name: "listingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListingType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operatingSystem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operatingSystemVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperatingSystemVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sizeInMbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SizeInMbs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreImages.DataOciCoreImagesImages\"}", isOptional: true)]
        public virtual oci.DataOciCoreImages.IDataOciCoreImagesImages? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreImages.IDataOciCoreImagesImages?>();
            set => SetInstanceProperty(value);
        }
    }
}
