using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiInterface(nativeType: typeof(IPersonUsCfpbDataRaceDetails), fullyQualifiedName: "stripe.person.PersonUsCfpbDataRaceDetails")]
    public interface IPersonUsCfpbDataRaceDetails
    {
        /// <summary>The persons race.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#race Person#race}
        /// </remarks>
        [JsiiProperty(name: "race", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Race
        {
            get
            {
                return null;
            }
        }

        /// <summary>Please specify your race, when other is selected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#race_other Person#race_other}
        /// </remarks>
        [JsiiProperty(name: "raceOther", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RaceOther
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPersonUsCfpbDataRaceDetails), fullyQualifiedName: "stripe.person.PersonUsCfpbDataRaceDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.Person.IPersonUsCfpbDataRaceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The persons race.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#race Person#race}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "race", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Race
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Please specify your race, when other is selected.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#race_other Person#race_other}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "raceOther", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RaceOther
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
