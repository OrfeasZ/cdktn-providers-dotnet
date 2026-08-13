using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceCustomerAddress), fullyQualifiedName: "stripe.invoice.InvoiceCustomerAddress")]
    public interface IInvoiceCustomerAddress
    {

        [JsiiTypeProxy(nativeType: typeof(IInvoiceCustomerAddress), fullyQualifiedName: "stripe.invoice.InvoiceCustomerAddress")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceCustomerAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
