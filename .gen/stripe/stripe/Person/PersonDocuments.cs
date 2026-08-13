using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiByValue(fqn: "stripe.person.PersonDocuments")]
    public class PersonDocuments : stripe.Person.IPersonDocuments
    {
        /// <summary>One or more documents that demonstrate proof that this person is authorized to represent the company.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#company_authorization Person#company_authorization}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "companyAuthorization", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsCompanyAuthorization\"}", isOptional: true)]
        public stripe.Person.IPersonDocumentsCompanyAuthorization? CompanyAuthorization
        {
            get;
            set;
        }

        /// <summary>One or more documents showing the person's passport page with photo and personal data.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#passport Person#passport}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passport", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsPassport\"}", isOptional: true)]
        public stripe.Person.IPersonDocumentsPassport? Passport
        {
            get;
            set;
        }

        /// <summary>One or more documents showing the person's visa required for living in the country where they are residing.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#visa Person#visa}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "visa", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsVisa\"}", isOptional: true)]
        public stripe.Person.IPersonDocumentsVisa? Visa
        {
            get;
            set;
        }
    }
}
