using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceCustomerShipping), fullyQualifiedName: "stripe.invoice.InvoiceCustomerShipping")]
    public interface IInvoiceCustomerShipping
    {

        [JsiiTypeProxy(nativeType: typeof(IInvoiceCustomerShipping), fullyQualifiedName: "stripe.invoice.InvoiceCustomerShipping")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceCustomerShipping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
