using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiInterface(nativeType: typeof(IPersonDocuments), fullyQualifiedName: "stripe.person.PersonDocuments")]
    public interface IPersonDocuments
    {
        /// <summary>One or more documents that demonstrate proof that this person is authorized to represent the company.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#company_authorization Person#company_authorization}
        /// </remarks>
        [JsiiProperty(name: "companyAuthorization", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsCompanyAuthorization\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Person.IPersonDocumentsCompanyAuthorization? CompanyAuthorization
        {
            get
            {
                return null;
            }
        }

        /// <summary>One or more documents showing the person's passport page with photo and personal data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#passport Person#passport}
        /// </remarks>
        [JsiiProperty(name: "passport", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsPassport\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Person.IPersonDocumentsPassport? Passport
        {
            get
            {
                return null;
            }
        }

        /// <summary>One or more documents showing the person's visa required for living in the country where they are residing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#visa Person#visa}
        /// </remarks>
        [JsiiProperty(name: "visa", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsVisa\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Person.IPersonDocumentsVisa? Visa
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPersonDocuments), fullyQualifiedName: "stripe.person.PersonDocuments")]
        internal sealed class _Proxy : DeputyBase, stripe.Person.IPersonDocuments
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>One or more documents that demonstrate proof that this person is authorized to represent the company.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#company_authorization Person#company_authorization}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "companyAuthorization", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsCompanyAuthorization\"}", isOptional: true)]
            public stripe.Person.IPersonDocumentsCompanyAuthorization? CompanyAuthorization
            {
                get => GetInstanceProperty<stripe.Person.IPersonDocumentsCompanyAuthorization?>();
            }

            /// <summary>One or more documents showing the person's passport page with photo and personal data.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#passport Person#passport}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passport", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsPassport\"}", isOptional: true)]
            public stripe.Person.IPersonDocumentsPassport? Passport
            {
                get => GetInstanceProperty<stripe.Person.IPersonDocumentsPassport?>();
            }

            /// <summary>One or more documents showing the person's visa required for living in the country where they are residing.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#visa Person#visa}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "visa", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsVisa\"}", isOptional: true)]
            public stripe.Person.IPersonDocumentsVisa? Visa
            {
                get => GetInstanceProperty<stripe.Person.IPersonDocumentsVisa?>();
            }
        }
    }
}
