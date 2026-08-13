using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceStatusTransitions), fullyQualifiedName: "stripe.invoice.InvoiceStatusTransitions")]
    public interface IInvoiceStatusTransitions
    {

        [JsiiTypeProxy(nativeType: typeof(IInvoiceStatusTransitions), fullyQualifiedName: "stripe.invoice.InvoiceStatusTransitions")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceStatusTransitions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
