using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiByValue(fqn: "stripe.person.PersonDocumentsPassport")]
    public class PersonDocumentsPassport : stripe.Person.IPersonDocumentsPassport
    {
        /// <summary>One or more document ids returned by a [file upload](https://api.stripe.com#create_file) with a `purpose` value of `account_requirement`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#files Person#files}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "files", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Files
        {
            get;
            set;
        }
    }
}
