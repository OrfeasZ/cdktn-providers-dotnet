using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayBillingInvoices
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayBillingInvoices.DataScalewayBillingInvoicesInvoicesOutputReference), fullyQualifiedName: "scaleway.dataScalewayBillingInvoices.DataScalewayBillingInvoicesInvoicesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayBillingInvoicesInvoicesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayBillingInvoicesInvoicesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayBillingInvoicesInvoicesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayBillingInvoicesInvoicesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "billingPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingPeriod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dueDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DueDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoiceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "issuedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Number
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "organizationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sellerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SellerName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stopDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StopDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalDiscount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalDiscount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalTax", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalTax
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalTaxed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalTaxed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalUndiscount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalUndiscount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalUntaxed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalUntaxed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayBillingInvoices.DataScalewayBillingInvoicesInvoices\"}", isOptional: true)]
        public virtual scaleway.DataScalewayBillingInvoices.IDataScalewayBillingInvoicesInvoices? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayBillingInvoices.IDataScalewayBillingInvoicesInvoices?>();
            set => SetInstanceProperty(value);
        }
    }
}
