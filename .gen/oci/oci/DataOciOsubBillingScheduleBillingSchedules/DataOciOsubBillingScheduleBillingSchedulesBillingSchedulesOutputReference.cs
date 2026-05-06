using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsubBillingScheduleBillingSchedules
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsubBillingScheduleBillingSchedules.DataOciOsubBillingScheduleBillingSchedulesBillingSchedulesOutputReference), fullyQualifiedName: "oci.dataOciOsubBillingScheduleBillingSchedules.DataOciOsubBillingScheduleBillingSchedulesBillingSchedulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsubBillingScheduleBillingSchedulesBillingSchedulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsubBillingScheduleBillingSchedulesBillingSchedulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsubBillingScheduleBillingSchedulesBillingSchedulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsubBillingScheduleBillingSchedulesBillingSchedulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Amount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arCustomerTransactionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArCustomerTransactionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arInvoiceNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ArInvoiceNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billingFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingFrequency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invoiceStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvoiceStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "netUnitPrice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetUnitPrice
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "orderNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrderNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "product", typeJson: "{\"fqn\":\"oci.dataOciOsubBillingScheduleBillingSchedules.DataOciOsubBillingScheduleBillingSchedulesBillingSchedulesProductList\"}")]
        public virtual oci.DataOciOsubBillingScheduleBillingSchedules.DataOciOsubBillingScheduleBillingSchedulesBillingSchedulesProductList Product
        {
            get => GetInstanceProperty<oci.DataOciOsubBillingScheduleBillingSchedules.DataOciOsubBillingScheduleBillingSchedulesBillingSchedulesProductList>()!;
        }

        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Quantity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeInvoicing", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeInvoicing
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsubBillingScheduleBillingSchedules.DataOciOsubBillingScheduleBillingSchedulesBillingSchedules\"}", isOptional: true)]
        public virtual oci.DataOciOsubBillingScheduleBillingSchedules.IDataOciOsubBillingScheduleBillingSchedulesBillingSchedules? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsubBillingScheduleBillingSchedules.IDataOciOsubBillingScheduleBillingSchedulesBillingSchedules?>();
            set => SetInstanceProperty(value);
        }
    }
}
