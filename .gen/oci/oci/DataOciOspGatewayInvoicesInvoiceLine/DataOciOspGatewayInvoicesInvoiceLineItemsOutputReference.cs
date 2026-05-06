using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOspGatewayInvoicesInvoiceLine
{
    [JsiiClass(nativeType: typeof(oci.DataOciOspGatewayInvoicesInvoiceLine.DataOciOspGatewayInvoicesInvoiceLineItemsOutputReference), fullyQualifiedName: "oci.dataOciOspGatewayInvoicesInvoiceLine.DataOciOspGatewayInvoicesInvoiceLineItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOspGatewayInvoicesInvoiceLineItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOspGatewayInvoicesInvoiceLineItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOspGatewayInvoicesInvoiceLineItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewayInvoicesInvoiceLineItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "currency", typeJson: "{\"fqn\":\"oci.dataOciOspGatewayInvoicesInvoiceLine.DataOciOspGatewayInvoicesInvoiceLineItemsCurrencyList\"}")]
        public virtual oci.DataOciOspGatewayInvoicesInvoiceLine.DataOciOspGatewayInvoicesInvoiceLineItemsCurrencyList Currency
        {
            get => GetInstanceProperty<oci.DataOciOspGatewayInvoicesInvoiceLine.DataOciOspGatewayInvoicesInvoiceLineItemsCurrencyList>()!;
        }

        [JsiiProperty(name: "netUnitPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetUnitPrice
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "orderNo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrderNo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Product
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Quantity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalPrice", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalPrice
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOspGatewayInvoicesInvoiceLine.DataOciOspGatewayInvoicesInvoiceLineItems\"}", isOptional: true)]
        public virtual oci.DataOciOspGatewayInvoicesInvoiceLine.IDataOciOspGatewayInvoicesInvoiceLineItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOspGatewayInvoicesInvoiceLine.IDataOciOspGatewayInvoicesInvoiceLineItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
