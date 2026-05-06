using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOnesubscriptionInvoices
{
    [JsiiClass(nativeType: typeof(oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesOutputReference), fullyQualifiedName: "oci.dataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOnesubscriptionInvoicesInvoicesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOnesubscriptionInvoicesInvoicesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOnesubscriptionInvoicesInvoicesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOnesubscriptionInvoicesInvoicesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "arInvoices", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArInvoices
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billToAddress", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesBillToAddressList\"}")]
        public virtual oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesBillToAddressList BillToAddress
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesBillToAddressList>()!;
        }

        [JsiiProperty(name: "billToContact", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesBillToContactList\"}")]
        public virtual oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesBillToContactList BillToContact
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesBillToContactList>()!;
        }

        [JsiiProperty(name: "billToCustomer", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesBillToCustomerList\"}")]
        public virtual oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesBillToCustomerList BillToCustomer
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesBillToCustomerList>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currency", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesCurrencyList\"}")]
        public virtual oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesCurrencyList Currency
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesCurrencyList>()!;
        }

        [JsiiProperty(name: "invoiceLines", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesInvoiceLinesList\"}")]
        public virtual oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesInvoiceLinesList InvoiceLines
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesInvoiceLinesList>()!;
        }

        [JsiiProperty(name: "organization", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesOrganizationList\"}")]
        public virtual oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesOrganizationList Organization
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesOrganizationList>()!;
        }

        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentTerm", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesPaymentTermList\"}")]
        public virtual oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesPaymentTermList PaymentTerm
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesPaymentTermList>()!;
        }

        [JsiiProperty(name: "receiptMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReceiptMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "spmInvoiceNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpmInvoiceNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeInvoiceDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeInvoiceDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoices\"}", isOptional: true)]
        public virtual oci.DataOciOnesubscriptionInvoices.IDataOciOnesubscriptionInvoicesInvoices? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionInvoices.IDataOciOnesubscriptionInvoicesInvoices?>();
            set => SetInstanceProperty(value);
        }
    }
}
