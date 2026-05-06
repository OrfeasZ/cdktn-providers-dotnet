using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMarketplacePublications
{
    [JsiiClass(nativeType: typeof(oci.DataOciMarketplacePublications.DataOciMarketplacePublicationsPublicationsPackageDetailsOutputReference), fullyQualifiedName: "oci.dataOciMarketplacePublications.DataOciMarketplacePublicationsPublicationsPackageDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMarketplacePublicationsPublicationsPackageDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMarketplacePublicationsPublicationsPackageDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMarketplacePublicationsPublicationsPackageDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMarketplacePublicationsPublicationsPackageDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "eula", typeJson: "{\"fqn\":\"oci.dataOciMarketplacePublications.DataOciMarketplacePublicationsPublicationsPackageDetailsEulaList\"}")]
        public virtual oci.DataOciMarketplacePublications.DataOciMarketplacePublicationsPublicationsPackageDetailsEulaList Eula
        {
            get => GetInstanceProperty<oci.DataOciMarketplacePublications.DataOciMarketplacePublicationsPublicationsPackageDetailsEulaList>()!;
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operatingSystem", typeJson: "{\"fqn\":\"oci.dataOciMarketplacePublications.DataOciMarketplacePublicationsPublicationsPackageDetailsOperatingSystemList\"}")]
        public virtual oci.DataOciMarketplacePublications.DataOciMarketplacePublicationsPublicationsPackageDetailsOperatingSystemList OperatingSystem
        {
            get => GetInstanceProperty<oci.DataOciMarketplacePublications.DataOciMarketplacePublicationsPublicationsPackageDetailsOperatingSystemList>()!;
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMarketplacePublications.DataOciMarketplacePublicationsPublicationsPackageDetails\"}", isOptional: true)]
        public virtual oci.DataOciMarketplacePublications.IDataOciMarketplacePublicationsPublicationsPackageDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMarketplacePublications.IDataOciMarketplacePublicationsPublicationsPackageDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
