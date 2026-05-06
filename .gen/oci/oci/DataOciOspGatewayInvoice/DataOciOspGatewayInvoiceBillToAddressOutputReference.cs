using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOspGatewayInvoice
{
    [JsiiClass(nativeType: typeof(oci.DataOciOspGatewayInvoice.DataOciOspGatewayInvoiceBillToAddressOutputReference), fullyQualifiedName: "oci.dataOciOspGatewayInvoice.DataOciOspGatewayInvoiceBillToAddressOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOspGatewayInvoiceBillToAddressOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOspGatewayInvoiceBillToAddressOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOspGatewayInvoiceBillToAddressOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewayInvoiceBillToAddressOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addressLine1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressLine1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "addressLine2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressLine2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "addressLine3", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressLine3
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "addressLine4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressLine4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string City
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "companyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompanyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contactName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContactName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "country", typeJson: "{\"fqn\":\"oci.dataOciOspGatewayInvoice.DataOciOspGatewayInvoiceBillToAddressCountryList\"}")]
        public virtual oci.DataOciOspGatewayInvoice.DataOciOspGatewayInvoiceBillToAddressCountryList Country
        {
            get => GetInstanceProperty<oci.DataOciOspGatewayInvoice.DataOciOspGatewayInvoiceBillToAddressCountryList>()!;
        }

        [JsiiProperty(name: "county", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string County
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostalCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "province", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Province
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreetName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streetNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreetNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOspGatewayInvoice.DataOciOspGatewayInvoiceBillToAddress\"}", isOptional: true)]
        public virtual oci.DataOciOspGatewayInvoice.IDataOciOspGatewayInvoiceBillToAddress? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOspGatewayInvoice.IDataOciOspGatewayInvoiceBillToAddress?>();
            set => SetInstanceProperty(value);
        }
    }
}
