using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiInterface(nativeType: typeof(IPersonVerification), fullyQualifiedName: "stripe.person.PersonVerification")]
    public interface IPersonVerification
    {
        /// <summary>A document showing address, either a passport, local ID card, or utility bill from a well-known utility company.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#additional_document Person#additional_document}
        /// </remarks>
        [JsiiProperty(name: "additionalDocument", typeJson: "{\"fqn\":\"stripe.person.PersonVerificationAdditionalDocument\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Person.IPersonVerificationAdditionalDocument? AdditionalDocument
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#document Person#document}.</summary>
        [JsiiProperty(name: "document", typeJson: "{\"fqn\":\"stripe.person.PersonVerificationDocument\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Person.IPersonVerificationDocument? Document
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPersonVerification), fullyQualifiedName: "stripe.person.PersonVerification")]
        internal sealed class _Proxy : DeputyBase, stripe.Person.IPersonVerification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A document showing address, either a passport, local ID card, or utility bill from a well-known utility company.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#additional_document Person#additional_document}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalDocument", typeJson: "{\"fqn\":\"stripe.person.PersonVerificationAdditionalDocument\"}", isOptional: true)]
            public stripe.Person.IPersonVerificationAdditionalDocument? AdditionalDocument
            {
                get => GetInstanceProperty<stripe.Person.IPersonVerificationAdditionalDocument?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#document Person#document}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "document", typeJson: "{\"fqn\":\"stripe.person.PersonVerificationDocument\"}", isOptional: true)]
            public stripe.Person.IPersonVerificationDocument? Document
            {
                get => GetInstanceProperty<stripe.Person.IPersonVerificationDocument?>();
            }
        }
    }
}
