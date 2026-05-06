using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciArtifactsContainerImages
{
    [JsiiClass(nativeType: typeof(oci.DataOciArtifactsContainerImages.DataOciArtifactsContainerImagesContainerImageCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciArtifactsContainerImages.DataOciArtifactsContainerImagesContainerImageCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciArtifactsContainerImagesContainerImageCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciArtifactsContainerImagesContainerImageCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciArtifactsContainerImagesContainerImageCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciArtifactsContainerImagesContainerImageCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Digest
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "layers", typeJson: "{\"fqn\":\"oci.dataOciArtifactsContainerImages.DataOciArtifactsContainerImagesContainerImageCollectionItemsLayersList\"}")]
        public virtual oci.DataOciArtifactsContainerImages.DataOciArtifactsContainerImagesContainerImageCollectionItemsLayersList Layers
        {
            get => GetInstanceProperty<oci.DataOciArtifactsContainerImages.DataOciArtifactsContainerImagesContainerImageCollectionItemsLayersList>()!;
        }

        [JsiiProperty(name: "layersSizeInBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LayersSizeInBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "manifestSizeInBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ManifestSizeInBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "pullCount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PullCount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "repositoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastPulled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastPulled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versions", typeJson: "{\"fqn\":\"oci.dataOciArtifactsContainerImages.DataOciArtifactsContainerImagesContainerImageCollectionItemsVersionsList\"}")]
        public virtual oci.DataOciArtifactsContainerImages.DataOciArtifactsContainerImagesContainerImageCollectionItemsVersionsList Versions
        {
            get => GetInstanceProperty<oci.DataOciArtifactsContainerImages.DataOciArtifactsContainerImagesContainerImageCollectionItemsVersionsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciArtifactsContainerImages.DataOciArtifactsContainerImagesContainerImageCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciArtifactsContainerImages.IDataOciArtifactsContainerImagesContainerImageCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciArtifactsContainerImages.IDataOciArtifactsContainerImagesContainerImageCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
