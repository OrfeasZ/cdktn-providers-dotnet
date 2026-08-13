using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceCustomerTaxIds), fullyQualifiedName: "stripe.invoice.InvoiceCustomerTaxIds")]
    public interface IInvoiceCustomerTaxIds
    {

        [JsiiTypeProxy(nativeType: typeof(IInvoiceCustomerTaxIds), fullyQualifiedName: "stripe.invoice.InvoiceCustomerTaxIds")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceCustomerTaxIds
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
