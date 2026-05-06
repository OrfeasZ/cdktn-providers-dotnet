using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciManagementAgentManagementAgentImages
{
    [JsiiClass(nativeType: typeof(oci.DataOciManagementAgentManagementAgentImages.DataOciManagementAgentManagementAgentImagesManagementAgentImagesOutputReference), fullyQualifiedName: "oci.dataOciManagementAgentManagementAgentImages.DataOciManagementAgentManagementAgentImagesManagementAgentImagesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciManagementAgentManagementAgentImagesManagementAgentImagesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciManagementAgentManagementAgentImagesManagementAgentImagesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciManagementAgentManagementAgentImagesManagementAgentImagesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciManagementAgentManagementAgentImagesManagementAgentImagesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "checksum", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Checksum
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageObjectStorageDetails", typeJson: "{\"fqn\":\"oci.dataOciManagementAgentManagementAgentImages.DataOciManagementAgentManagementAgentImagesManagementAgentImagesImageObjectStorageDetailsList\"}")]
        public virtual oci.DataOciManagementAgentManagementAgentImages.DataOciManagementAgentManagementAgentImagesManagementAgentImagesImageObjectStorageDetailsList ImageObjectStorageDetails
        {
            get => GetInstanceProperty<oci.DataOciManagementAgentManagementAgentImages.DataOciManagementAgentManagementAgentImagesManagementAgentImagesImageObjectStorageDetailsList>()!;
        }

        [JsiiProperty(name: "objectUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageArchitectureType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageArchitectureType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platformType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciManagementAgentManagementAgentImages.DataOciManagementAgentManagementAgentImagesManagementAgentImages\"}", isOptional: true)]
        public virtual oci.DataOciManagementAgentManagementAgentImages.IDataOciManagementAgentManagementAgentImagesManagementAgentImages? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciManagementAgentManagementAgentImages.IDataOciManagementAgentManagementAgentImagesManagementAgentImages?>();
            set => SetInstanceProperty(value);
        }
    }
}
