using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiInterface(nativeType: typeof(IPersonUsCfpbDataEthnicityDetails), fullyQualifiedName: "stripe.person.PersonUsCfpbDataEthnicityDetails")]
    public interface IPersonUsCfpbDataEthnicityDetails
    {
        /// <summary>The persons ethnicity.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ethnicity Person#ethnicity}
        /// </remarks>
        [JsiiProperty(name: "ethnicity", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Ethnicity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Please specify your origin, when other is selected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ethnicity_other Person#ethnicity_other}
        /// </remarks>
        [JsiiProperty(name: "ethnicityOther", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EthnicityOther
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPersonUsCfpbDataEthnicityDetails), fullyQualifiedName: "stripe.person.PersonUsCfpbDataEthnicityDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.Person.IPersonUsCfpbDataEthnicityDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The persons ethnicity.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ethnicity Person#ethnicity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ethnicity", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Ethnicity
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Please specify your origin, when other is selected.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ethnicity_other Person#ethnicity_other}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ethnicityOther", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EthnicityOther
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
