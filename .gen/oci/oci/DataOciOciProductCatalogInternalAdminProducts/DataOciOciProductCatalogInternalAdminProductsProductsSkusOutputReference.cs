using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOciProductCatalogInternalAdminProducts
{
    [JsiiClass(nativeType: typeof(oci.DataOciOciProductCatalogInternalAdminProducts.DataOciOciProductCatalogInternalAdminProductsProductsSkusOutputReference), fullyQualifiedName: "oci.dataOciOciProductCatalogInternalAdminProducts.DataOciOciProductCatalogInternalAdminProductsProductsSkusOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOciProductCatalogInternalAdminProductsProductsSkusOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOciProductCatalogInternalAdminProductsProductsSkusOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOciProductCatalogInternalAdminProductsProductsSkusOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOciProductCatalogInternalAdminProductsProductsSkusOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bpartNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BpartNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOciProductCatalogInternalAdminProducts.DataOciOciProductCatalogInternalAdminProductsProductsSkus\"}", isOptional: true)]
        public virtual oci.DataOciOciProductCatalogInternalAdminProducts.IDataOciOciProductCatalogInternalAdminProductsProductsSkus? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOciProductCatalogInternalAdminProducts.IDataOciOciProductCatalogInternalAdminProductsProductsSkus?>();
            set => SetInstanceProperty(value);
        }
    }
}
