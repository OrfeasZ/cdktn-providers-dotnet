using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiInterface(nativeType: typeof(IPersonDocumentsVisa), fullyQualifiedName: "stripe.person.PersonDocumentsVisa")]
    public interface IPersonDocumentsVisa
    {
        /// <summary>One or more document ids returned by a [file upload](https://api.stripe.com#create_file) with a `purpose` value of `account_requirement`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#files Person#files}
        /// </remarks>
        [JsiiProperty(name: "files", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Files
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPersonDocumentsVisa), fullyQualifiedName: "stripe.person.PersonDocumentsVisa")]
        internal sealed class _Proxy : DeputyBase, stripe.Person.IPersonDocumentsVisa
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>One or more document ids returned by a [file upload](https://api.stripe.com#create_file) with a `purpose` value of `account_requirement`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#files Person#files}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "files", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Files
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
