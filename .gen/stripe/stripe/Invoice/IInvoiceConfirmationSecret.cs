using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceConfirmationSecret), fullyQualifiedName: "stripe.invoice.InvoiceConfirmationSecret")]
    public interface IInvoiceConfirmationSecret
    {

        [JsiiTypeProxy(nativeType: typeof(IInvoiceConfirmationSecret), fullyQualifiedName: "stripe.invoice.InvoiceConfirmationSecret")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceConfirmationSecret
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
