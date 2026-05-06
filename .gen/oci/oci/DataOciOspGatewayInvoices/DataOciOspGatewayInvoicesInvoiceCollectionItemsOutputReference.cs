using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOspGatewayInvoices
{
    [JsiiClass(nativeType: typeof(oci.DataOciOspGatewayInvoices.DataOciOspGatewayInvoicesInvoiceCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOspGatewayInvoices.DataOciOspGatewayInvoicesInvoiceCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOspGatewayInvoicesInvoiceCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOspGatewayInvoicesInvoiceCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOspGatewayInvoicesInvoiceCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewayInvoicesInvoiceCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "billToAddress", typeJson: "{\"fqn\":\"oci.dataOciOspGatewayInvoices.DataOciOspGatewayInvoicesInvoiceCollectionItemsBillToAddressList\"}")]
        public virtual oci.DataOciOspGatewayInvoices.DataOciOspGatewayInvoicesInvoiceCollectionItemsBillToAddressList BillToAddress
        {
            get => GetInstanceProperty<oci.DataOciOspGatewayInvoices.DataOciOspGatewayInvoicesInvoiceCollectionItemsBillToAddressList>()!;
        }

        [JsiiProperty(name: "currency", typeJson: "{\"fqn\":\"oci.dataOciOspGatewayInvoices.DataOciOspGatewayInvoicesInvoiceCollectionItemsCurrencyList\"}")]
        public virtual oci.DataOciOspGatewayInvoices.DataOciOspGatewayInvoicesInvoiceCollectionItemsCurrencyList Currency
        {
            get => GetInstanceProperty<oci.DataOciOspGatewayInvoices.DataOciOspGatewayInvoicesInvoiceCollectionItemsCurrencyList>()!;
        }

        [JsiiProperty(name: "internalInvoiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InternalInvoiceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InvoiceAmount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "invoiceAmountAdjusted", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InvoiceAmountAdjusted
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "invoiceAmountApplied", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InvoiceAmountApplied
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "invoiceAmountCredited", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InvoiceAmountCredited
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "invoiceAmountDue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InvoiceAmountDue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "invoiceAmountInDispute", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InvoiceAmountInDispute
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "invoiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoiceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoiceNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoicePoNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoicePoNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceRefNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoiceRefNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoiceStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoiceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isCreditCardPayable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCreditCardPayable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDisplayDownloadPdf", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDisplayDownloadPdf
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDisplayViewPdf", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDisplayViewPdf
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPaid", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPaid
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPayable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPayable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPaymentFailed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPaymentFailed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPdfEmailAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPdfEmailAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lastPaymentDetail", typeJson: "{\"fqn\":\"oci.dataOciOspGatewayInvoices.DataOciOspGatewayInvoicesInvoiceCollectionItemsLastPaymentDetailList\"}")]
        public virtual oci.DataOciOspGatewayInvoices.DataOciOspGatewayInvoicesInvoiceCollectionItemsLastPaymentDetailList LastPaymentDetail
        {
            get => GetInstanceProperty<oci.DataOciOspGatewayInvoices.DataOciOspGatewayInvoicesInvoiceCollectionItemsLastPaymentDetailList>()!;
        }

        [JsiiProperty(name: "partyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paymentTerms", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PaymentTerms
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preferredEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriptionIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubscriptionIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tax
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeInvoice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeInvoice
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeInvoiceDue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeInvoiceDue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOspGatewayInvoices.DataOciOspGatewayInvoicesInvoiceCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOspGatewayInvoices.IDataOciOspGatewayInvoicesInvoiceCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOspGatewayInvoices.IDataOciOspGatewayInvoicesInvoiceCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
