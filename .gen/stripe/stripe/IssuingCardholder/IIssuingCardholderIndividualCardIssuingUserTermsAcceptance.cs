using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiInterface(nativeType: typeof(IIssuingCardholderIndividualCardIssuingUserTermsAcceptance), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderIndividualCardIssuingUserTermsAcceptance")]
    public interface IIssuingCardholderIndividualCardIssuingUserTermsAcceptance
    {
        /// <summary>The Unix timestamp marking when the cardholder accepted the Authorized User Terms.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#date IssuingCardholder#date}
        /// </remarks>
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Date
        {
            get
            {
                return null;
            }
        }

        /// <summary>The IP address from which the cardholder accepted the Authorized User Terms.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#ip IssuingCardholder#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>The user agent of the browser from which the cardholder accepted the Authorized User Terms.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#user_agent IssuingCardholder#user_agent}
        /// </remarks>
        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserAgent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardholderIndividualCardIssuingUserTermsAcceptance), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderIndividualCardIssuingUserTermsAcceptance")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuingUserTermsAcceptance
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Unix timestamp marking when the cardholder accepted the Authorized User Terms.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#date IssuingCardholder#date}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Date
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The IP address from which the cardholder accepted the Authorized User Terms.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#ip IssuingCardholder#ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The user agent of the browser from which the cardholder accepted the Authorized User Terms.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#user_agent IssuingCardholder#user_agent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserAgent
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
