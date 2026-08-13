using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiByValue(fqn: "stripe.person.PersonVerificationAdditionalDocument")]
    public class PersonVerificationAdditionalDocument : stripe.Person.IPersonVerificationAdditionalDocument
    {
        /// <summary>The back of an ID returned by a [file upload](https://api.stripe.com#create_file) with a `purpose` value of `identity_document`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#back Person#back}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "back", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Back
        {
            get;
            set;
        }

        /// <summary>The front of an ID returned by a [file upload](https://api.stripe.com#create_file) with a `purpose` value of `identity_document`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#front Person#front}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "front", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Front
        {
            get;
            set;
        }
    }
}
