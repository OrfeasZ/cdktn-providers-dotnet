using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOnesubscriptionInvoices
{
    [JsiiClass(nativeType: typeof(oci.DataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesBillToCustomerOutputReference), fullyQualifiedName: "oci.dataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesBillToCustomerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOnesubscriptionInvoicesInvoicesBillToCustomerOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOnesubscriptionInvoicesInvoicesBillToCustomerOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOnesubscriptionInvoicesInvoicesBillToCustomerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOnesubscriptionInvoicesInvoicesBillToCustomerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "customerChainType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerChainType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isChainCustomer", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsChainCustomer
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPublicSector", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPublicSector
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namePhonetic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamePhonetic
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tcaCustomerAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TcaCustomerAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tcaCustomerAccountNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TcaCustomerAccountNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tcaPartyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TcaPartyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tcaPartyNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TcaPartyNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOnesubscriptionInvoices.DataOciOnesubscriptionInvoicesInvoicesBillToCustomer\"}", isOptional: true)]
        public virtual oci.DataOciOnesubscriptionInvoices.IDataOciOnesubscriptionInvoicesInvoicesBillToCustomer? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOnesubscriptionInvoices.IDataOciOnesubscriptionInvoicesInvoicesBillToCustomer?>();
            set => SetInstanceProperty(value);
        }
    }
}
