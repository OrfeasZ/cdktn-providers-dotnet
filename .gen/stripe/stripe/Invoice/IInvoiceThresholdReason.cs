using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceThresholdReason), fullyQualifiedName: "stripe.invoice.InvoiceThresholdReason")]
    public interface IInvoiceThresholdReason
    {

        [JsiiTypeProxy(nativeType: typeof(IInvoiceThresholdReason), fullyQualifiedName: "stripe.invoice.InvoiceThresholdReason")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceThresholdReason
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
