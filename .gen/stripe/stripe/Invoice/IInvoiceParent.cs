using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceParent), fullyQualifiedName: "stripe.invoice.InvoiceParent")]
    public interface IInvoiceParent
    {

        [JsiiTypeProxy(nativeType: typeof(IInvoiceParent), fullyQualifiedName: "stripe.invoice.InvoiceParent")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceParent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
