using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLicenseManagerProductLicenseConsumers
{
    [JsiiClass(nativeType: typeof(oci.DataOciLicenseManagerProductLicenseConsumers.DataOciLicenseManagerProductLicenseConsumersItemsOutputReference), fullyQualifiedName: "oci.dataOciLicenseManagerProductLicenseConsumers.DataOciLicenseManagerProductLicenseConsumersItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLicenseManagerProductLicenseConsumersItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLicenseManagerProductLicenseConsumersItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLicenseManagerProductLicenseConsumersItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLicenseManagerProductLicenseConsumersItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "areAllOptionsAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AreAllOptionsAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isBaseLicenseAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBaseLicenseAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "licenseUnitsConsumed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LicenseUnitsConsumed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "licenseUnitType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseUnitType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "missingProducts", typeJson: "{\"fqn\":\"oci.dataOciLicenseManagerProductLicenseConsumers.DataOciLicenseManagerProductLicenseConsumersItemsMissingProductsList\"}")]
        public virtual oci.DataOciLicenseManagerProductLicenseConsumers.DataOciLicenseManagerProductLicenseConsumersItemsMissingProductsList MissingProducts
        {
            get => GetInstanceProperty<oci.DataOciLicenseManagerProductLicenseConsumers.DataOciLicenseManagerProductLicenseConsumersItemsMissingProductsList>()!;
        }

        [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceCompartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceCompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceCompartmentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceCompartmentName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceUnitCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ResourceUnitCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "resourceUnitType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceUnitType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLicenseManagerProductLicenseConsumers.DataOciLicenseManagerProductLicenseConsumersItems\"}", isOptional: true)]
        public virtual oci.DataOciLicenseManagerProductLicenseConsumers.IDataOciLicenseManagerProductLicenseConsumersItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLicenseManagerProductLicenseConsumers.IDataOciLicenseManagerProductLicenseConsumersItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
