using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    [JsiiInterface(nativeType: typeof(IIssuingCardShippingAddressValidation), fullyQualifiedName: "stripe.issuingCard.IssuingCardShippingAddressValidation")]
    public interface IIssuingCardShippingAddressValidation
    {
        /// <summary>The address validation capabilities to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#mode IssuingCard#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardShippingAddressValidation), fullyQualifiedName: "stripe.issuingCard.IssuingCardShippingAddressValidation")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCard.IIssuingCardShippingAddressValidation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The address validation capabilities to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#mode IssuingCard#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
