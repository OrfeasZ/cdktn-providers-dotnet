using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceStatusDetails), fullyQualifiedName: "stripe.invoice.InvoiceStatusDetails")]
    public interface IInvoiceStatusDetails
    {

        [JsiiTypeProxy(nativeType: typeof(IInvoiceStatusDetails), fullyQualifiedName: "stripe.invoice.InvoiceStatusDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceStatusDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
