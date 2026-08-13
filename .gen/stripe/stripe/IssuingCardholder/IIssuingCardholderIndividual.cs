using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiInterface(nativeType: typeof(IIssuingCardholderIndividual), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderIndividual")]
    public interface IIssuingCardholderIndividual
    {
        /// <summary>Information related to the card_issuing program for this cardholder.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#card_issuing IssuingCardholder#card_issuing}
        /// </remarks>
        [JsiiProperty(name: "cardIssuing", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualCardIssuing\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuing? CardIssuing
        {
            get
            {
                return null;
            }
        }

        /// <summary>The date of birth of this cardholder.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#dob IssuingCardholder#dob}
        /// </remarks>
        [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualDob\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingCardholder.IIssuingCardholderIndividualDob? Dob
        {
            get
            {
                return null;
            }
        }

        /// <summary>The first name of this cardholder.</summary>
        /// <remarks>
        /// Required before activating Cards. This field cannot contain any numbers, special characters (except periods, commas, hyphens, spaces and apostrophes) or non-latin letters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#first_name IssuingCardholder#first_name}
        /// </remarks>
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FirstName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The last name of this cardholder.</summary>
        /// <remarks>
        /// Required before activating Cards. This field cannot contain any numbers, special characters (except periods, commas, hyphens, spaces and apostrophes) or non-latin letters.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#last_name IssuingCardholder#last_name}
        /// </remarks>
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Government-issued ID document for this cardholder.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#verification IssuingCardholder#verification}
        /// </remarks>
        [JsiiProperty(name: "verification", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualVerification\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.IssuingCardholder.IIssuingCardholderIndividualVerification? Verification
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardholderIndividual), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderIndividual")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCardholder.IIssuingCardholderIndividual
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Information related to the card_issuing program for this cardholder.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#card_issuing IssuingCardholder#card_issuing}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cardIssuing", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualCardIssuing\"}", isOptional: true)]
            public stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuing? CardIssuing
            {
                get => GetInstanceProperty<stripe.IssuingCardholder.IIssuingCardholderIndividualCardIssuing?>();
            }

            /// <summary>The date of birth of this cardholder.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#dob IssuingCardholder#dob}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualDob\"}", isOptional: true)]
            public stripe.IssuingCardholder.IIssuingCardholderIndividualDob? Dob
            {
                get => GetInstanceProperty<stripe.IssuingCardholder.IIssuingCardholderIndividualDob?>();
            }

            /// <summary>The first name of this cardholder.</summary>
            /// <remarks>
            /// Required before activating Cards. This field cannot contain any numbers, special characters (except periods, commas, hyphens, spaces and apostrophes) or non-latin letters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#first_name IssuingCardholder#first_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FirstName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The last name of this cardholder.</summary>
            /// <remarks>
            /// Required before activating Cards. This field cannot contain any numbers, special characters (except periods, commas, hyphens, spaces and apostrophes) or non-latin letters.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#last_name IssuingCardholder#last_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Government-issued ID document for this cardholder.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#verification IssuingCardholder#verification}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verification", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualVerification\"}", isOptional: true)]
            public stripe.IssuingCardholder.IIssuingCardholderIndividualVerification? Verification
            {
                get => GetInstanceProperty<stripe.IssuingCardholder.IIssuingCardholderIndividualVerification?>();
            }
        }
    }
}
