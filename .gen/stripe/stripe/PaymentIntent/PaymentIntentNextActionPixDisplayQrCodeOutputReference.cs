using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiClass(nativeType: typeof(stripe.PaymentIntent.PaymentIntentNextActionPixDisplayQrCodeOutputReference), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentNextActionPixDisplayQrCodeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentIntentNextActionPixDisplayQrCodeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentIntentNextActionPixDisplayQrCodeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentIntentNextActionPixDisplayQrCodeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentIntentNextActionPixDisplayQrCodeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Data
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpiresAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "hostedInstructionsUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedInstructionsUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageUrlPng", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageUrlPng
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageUrlSvg", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageUrlSvg
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentNextActionPixDisplayQrCode\"}", isOptional: true)]
        public virtual stripe.PaymentIntent.IPaymentIntentNextActionPixDisplayQrCode? InternalValue
        {
            get => GetInstanceProperty<stripe.PaymentIntent.IPaymentIntentNextActionPixDisplayQrCode?>();
            set => SetInstanceProperty(value);
        }
    }
}
