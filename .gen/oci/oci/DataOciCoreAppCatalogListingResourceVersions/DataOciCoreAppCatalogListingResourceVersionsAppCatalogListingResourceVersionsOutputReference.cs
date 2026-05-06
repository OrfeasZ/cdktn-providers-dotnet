using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreAppCatalogListingResourceVersions
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreAppCatalogListingResourceVersions.DataOciCoreAppCatalogListingResourceVersionsAppCatalogListingResourceVersionsOutputReference), fullyQualifiedName: "oci.dataOciCoreAppCatalogListingResourceVersions.DataOciCoreAppCatalogListingResourceVersionsAppCatalogListingResourceVersionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreAppCatalogListingResourceVersionsAppCatalogListingResourceVersionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreAppCatalogListingResourceVersionsAppCatalogListingResourceVersionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreAppCatalogListingResourceVersionsAppCatalogListingResourceVersionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreAppCatalogListingResourceVersionsAppCatalogListingResourceVersionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessiblePorts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] AccessiblePorts
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "allowedActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedActions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "availableRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailableRegions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "compatibleShapes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CompatibleShapes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "listingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listingResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListingResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "listingResourceVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ListingResourceVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timePublished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimePublished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreAppCatalogListingResourceVersions.DataOciCoreAppCatalogListingResourceVersionsAppCatalogListingResourceVersions\"}", isOptional: true)]
        public virtual oci.DataOciCoreAppCatalogListingResourceVersions.IDataOciCoreAppCatalogListingResourceVersionsAppCatalogListingResourceVersions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreAppCatalogListingResourceVersions.IDataOciCoreAppCatalogListingResourceVersionsAppCatalogListingResourceVersions?>();
            set => SetInstanceProperty(value);
        }
    }
}
