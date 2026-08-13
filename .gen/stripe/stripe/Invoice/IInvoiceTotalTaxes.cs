using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceTotalTaxes), fullyQualifiedName: "stripe.invoice.InvoiceTotalTaxes")]
    public interface IInvoiceTotalTaxes
    {

        [JsiiTypeProxy(nativeType: typeof(IInvoiceTotalTaxes), fullyQualifiedName: "stripe.invoice.InvoiceTotalTaxes")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceTotalTaxes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
