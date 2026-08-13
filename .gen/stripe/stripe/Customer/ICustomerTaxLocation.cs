using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiInterface(nativeType: typeof(ICustomerTaxLocation), fullyQualifiedName: "stripe.customer.CustomerTaxLocation")]
    public interface ICustomerTaxLocation
    {

        [JsiiTypeProxy(nativeType: typeof(ICustomerTaxLocation), fullyQualifiedName: "stripe.customer.CustomerTaxLocation")]
        internal sealed class _Proxy : DeputyBase, stripe.Customer.ICustomerTaxLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
