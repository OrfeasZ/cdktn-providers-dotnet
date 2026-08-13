using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCard
{
    [JsiiInterface(nativeType: typeof(IIssuingCardLifecycleControls), fullyQualifiedName: "stripe.issuingCard.IssuingCardLifecycleControls")]
    public interface IIssuingCardLifecycleControls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#cancel_after IssuingCard#cancel_after}.</summary>
        [JsiiProperty(name: "cancelAfter", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControlsCancelAfter\"}")]
        stripe.IssuingCard.IIssuingCardLifecycleControlsCancelAfter CancelAfter
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardLifecycleControls), fullyQualifiedName: "stripe.issuingCard.IssuingCardLifecycleControls")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCard.IIssuingCardLifecycleControls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_card#cancel_after IssuingCard#cancel_after}.</summary>
            [JsiiProperty(name: "cancelAfter", typeJson: "{\"fqn\":\"stripe.issuingCard.IssuingCardLifecycleControlsCancelAfter\"}")]
            public stripe.IssuingCard.IIssuingCardLifecycleControlsCancelAfter CancelAfter
            {
                get => GetInstanceProperty<stripe.IssuingCard.IIssuingCardLifecycleControlsCancelAfter>()!;
            }
        }
    }
}
