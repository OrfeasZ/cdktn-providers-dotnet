using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLicenseManagerTopUtilizedProductLicenses
{
    [JsiiClass(nativeType: typeof(oci.DataOciLicenseManagerTopUtilizedProductLicenses.DataOciLicenseManagerTopUtilizedProductLicensesItemsOutputReference), fullyQualifiedName: "oci.dataOciLicenseManagerTopUtilizedProductLicenses.DataOciLicenseManagerTopUtilizedProductLicensesItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLicenseManagerTopUtilizedProductLicensesItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLicenseManagerTopUtilizedProductLicensesItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLicenseManagerTopUtilizedProductLicensesItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLicenseManagerTopUtilizedProductLicensesItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "isUnlimited", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsUnlimited
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "productLicenseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductLicenseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalLicenseUnitCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalLicenseUnitCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalUnitsConsumed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalUnitsConsumed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "unitType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnitType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLicenseManagerTopUtilizedProductLicenses.DataOciLicenseManagerTopUtilizedProductLicensesItems\"}", isOptional: true)]
        public virtual oci.DataOciLicenseManagerTopUtilizedProductLicenses.IDataOciLicenseManagerTopUtilizedProductLicensesItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLicenseManagerTopUtilizedProductLicenses.IDataOciLicenseManagerTopUtilizedProductLicensesItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
