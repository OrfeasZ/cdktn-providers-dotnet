using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiInterface(nativeType: typeof(IPersonUsCfpbData), fullyQualifiedName: "stripe.person.PersonUsCfpbData")]
    public interface IPersonUsCfpbData
    {
        /// <summary>The persons ethnicity details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ethnicity_details Person#ethnicity_details}
        /// </remarks>
        [JsiiProperty(name: "ethnicityDetails", typeJson: "{\"fqn\":\"stripe.person.PersonUsCfpbDataEthnicityDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Person.IPersonUsCfpbDataEthnicityDetails? EthnicityDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>The persons race details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#race_details Person#race_details}
        /// </remarks>
        [JsiiProperty(name: "raceDetails", typeJson: "{\"fqn\":\"stripe.person.PersonUsCfpbDataRaceDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.Person.IPersonUsCfpbDataRaceDetails? RaceDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>The persons self-identified gender.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#self_identified_gender Person#self_identified_gender}
        /// </remarks>
        [JsiiProperty(name: "selfIdentifiedGender", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SelfIdentifiedGender
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPersonUsCfpbData), fullyQualifiedName: "stripe.person.PersonUsCfpbData")]
        internal sealed class _Proxy : DeputyBase, stripe.Person.IPersonUsCfpbData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The persons ethnicity details.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ethnicity_details Person#ethnicity_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ethnicityDetails", typeJson: "{\"fqn\":\"stripe.person.PersonUsCfpbDataEthnicityDetails\"}", isOptional: true)]
            public stripe.Person.IPersonUsCfpbDataEthnicityDetails? EthnicityDetails
            {
                get => GetInstanceProperty<stripe.Person.IPersonUsCfpbDataEthnicityDetails?>();
            }

            /// <summary>The persons race details.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#race_details Person#race_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "raceDetails", typeJson: "{\"fqn\":\"stripe.person.PersonUsCfpbDataRaceDetails\"}", isOptional: true)]
            public stripe.Person.IPersonUsCfpbDataRaceDetails? RaceDetails
            {
                get => GetInstanceProperty<stripe.Person.IPersonUsCfpbDataRaceDetails?>();
            }

            /// <summary>The persons self-identified gender.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#self_identified_gender Person#self_identified_gender}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selfIdentifiedGender", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SelfIdentifiedGender
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
