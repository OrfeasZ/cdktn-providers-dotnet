using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceCustomerShippingAddress), fullyQualifiedName: "stripe.invoice.InvoiceCustomerShippingAddress")]
    public interface IInvoiceCustomerShippingAddress
    {

        [JsiiTypeProxy(nativeType: typeof(IInvoiceCustomerShippingAddress), fullyQualifiedName: "stripe.invoice.InvoiceCustomerShippingAddress")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceCustomerShippingAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
