using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiInterface(nativeType: typeof(IIssuingCardholderBilling), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderBilling")]
    public interface IIssuingCardholderBilling
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#address IssuingCardholder#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderBillingAddress\"}")]
        stripe.IssuingCardholder.IIssuingCardholderBillingAddress Address
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardholderBilling), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderBilling")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCardholder.IIssuingCardholderBilling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#address IssuingCardholder#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderBillingAddress\"}")]
            public stripe.IssuingCardholder.IIssuingCardholderBillingAddress Address
            {
                get => GetInstanceProperty<stripe.IssuingCardholder.IIssuingCardholderBillingAddress>()!;
            }
        }
    }
}
