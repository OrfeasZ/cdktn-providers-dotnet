using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person stripe_person}.</summary>
    [JsiiClass(nativeType: typeof(stripe.Person.Person), fullyQualifiedName: "stripe.person.Person", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.person.PersonConfig\"}}]")]
    public class Person : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person stripe_person} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Person(Constructs.Construct scope, string id, stripe.Person.IPersonConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.Person.IPersonConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Person(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Person(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Person resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Person to import.</param>
        /// <param name="importFromId">The id of the existing Person that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Person to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Person to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Person that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Person to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.Person.Person), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAdditionalTosAcceptances", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonAdditionalTosAcceptances\"}}]")]
        public virtual void PutAdditionalTosAcceptances(stripe.Person.IPersonAdditionalTosAcceptances @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonAdditionalTosAcceptances)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonAddress\"}}]")]
        public virtual void PutAddress(stripe.Person.IPersonAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAddressKana", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonAddressKana\"}}]")]
        public virtual void PutAddressKana(stripe.Person.IPersonAddressKana @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonAddressKana)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAddressKanji", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonAddressKanji\"}}]")]
        public virtual void PutAddressKanji(stripe.Person.IPersonAddressKanji @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonAddressKanji)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDob", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonDob\"}}]")]
        public virtual void PutDob(stripe.Person.IPersonDob @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonDob)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDocuments", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonDocuments\"}}]")]
        public virtual void PutDocuments(stripe.Person.IPersonDocuments @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonDocuments)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegisteredAddress", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonRegisteredAddress\"}}]")]
        public virtual void PutRegisteredAddress(stripe.Person.IPersonRegisteredAddress @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonRegisteredAddress)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRelationship", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonRelationship\"}}]")]
        public virtual void PutRelationship(stripe.Person.IPersonRelationship @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonRelationship)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsCfpbData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonUsCfpbData\"}}]")]
        public virtual void PutUsCfpbData(stripe.Person.IPersonUsCfpbData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonUsCfpbData)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.person.PersonVerification\"}}]")]
        public virtual void PutVerification(stripe.Person.IPersonVerification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.Person.IPersonVerification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalTosAcceptances")]
        public virtual void ResetAdditionalTosAcceptances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAddress")]
        public virtual void ResetAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAddressKana")]
        public virtual void ResetAddressKana()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAddressKanji")]
        public virtual void ResetAddressKanji()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDob")]
        public virtual void ResetDob()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDocuments")]
        public virtual void ResetDocuments()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmail")]
        public virtual void ResetEmail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirstName")]
        public virtual void ResetFirstName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirstNameKana")]
        public virtual void ResetFirstNameKana()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirstNameKanji")]
        public virtual void ResetFirstNameKanji()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFullNameAliases")]
        public virtual void ResetFullNameAliases()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGender")]
        public virtual void ResetGender()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdNumber")]
        public virtual void ResetIdNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdNumberSecondary")]
        public virtual void ResetIdNumberSecondary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastName")]
        public virtual void ResetLastName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastNameKana")]
        public virtual void ResetLastNameKana()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastNameKanji")]
        public virtual void ResetLastNameKanji()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaidenName")]
        public virtual void ResetMaidenName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNationality")]
        public virtual void ResetNationality()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPersonToken")]
        public virtual void ResetPersonToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhone")]
        public virtual void ResetPhone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPoliticalExposure")]
        public virtual void ResetPoliticalExposure()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegisteredAddress")]
        public virtual void ResetRegisteredAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRelationship")]
        public virtual void ResetRelationship()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSsnLast4")]
        public virtual void ResetSsnLast4()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsCfpbData")]
        public virtual void ResetUsCfpbData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerification")]
        public virtual void ResetVerification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(stripe.Person.Person))!;

        [JsiiProperty(name: "additionalTosAcceptances", typeJson: "{\"fqn\":\"stripe.person.PersonAdditionalTosAcceptancesOutputReference\"}")]
        public virtual stripe.Person.PersonAdditionalTosAcceptancesOutputReference AdditionalTosAcceptances
        {
            get => GetInstanceProperty<stripe.Person.PersonAdditionalTosAcceptancesOutputReference>()!;
        }

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.person.PersonAddressOutputReference\"}")]
        public virtual stripe.Person.PersonAddressOutputReference Address
        {
            get => GetInstanceProperty<stripe.Person.PersonAddressOutputReference>()!;
        }

        [JsiiProperty(name: "addressKana", typeJson: "{\"fqn\":\"stripe.person.PersonAddressKanaOutputReference\"}")]
        public virtual stripe.Person.PersonAddressKanaOutputReference AddressKana
        {
            get => GetInstanceProperty<stripe.Person.PersonAddressKanaOutputReference>()!;
        }

        [JsiiProperty(name: "addressKanji", typeJson: "{\"fqn\":\"stripe.person.PersonAddressKanjiOutputReference\"}")]
        public virtual stripe.Person.PersonAddressKanjiOutputReference AddressKanji
        {
            get => GetInstanceProperty<stripe.Person.PersonAddressKanjiOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dob", typeJson: "{\"fqn\":\"stripe.person.PersonDobOutputReference\"}")]
        public virtual stripe.Person.PersonDobOutputReference Dob
        {
            get => GetInstanceProperty<stripe.Person.PersonDobOutputReference>()!;
        }

        [JsiiProperty(name: "documents", typeJson: "{\"fqn\":\"stripe.person.PersonDocumentsOutputReference\"}")]
        public virtual stripe.Person.PersonDocumentsOutputReference Documents
        {
            get => GetInstanceProperty<stripe.Person.PersonDocumentsOutputReference>()!;
        }

        [JsiiProperty(name: "futureRequirements", typeJson: "{\"fqn\":\"stripe.person.PersonFutureRequirementsOutputReference\"}")]
        public virtual stripe.Person.PersonFutureRequirementsOutputReference FutureRequirements
        {
            get => GetInstanceProperty<stripe.Person.PersonFutureRequirementsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idNumberProvided", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdNumberProvided
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idNumberSecondaryProvided", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdNumberSecondaryProvided
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "registeredAddress", typeJson: "{\"fqn\":\"stripe.person.PersonRegisteredAddressOutputReference\"}")]
        public virtual stripe.Person.PersonRegisteredAddressOutputReference RegisteredAddress
        {
            get => GetInstanceProperty<stripe.Person.PersonRegisteredAddressOutputReference>()!;
        }

        [JsiiProperty(name: "relationship", typeJson: "{\"fqn\":\"stripe.person.PersonRelationshipOutputReference\"}")]
        public virtual stripe.Person.PersonRelationshipOutputReference Relationship
        {
            get => GetInstanceProperty<stripe.Person.PersonRelationshipOutputReference>()!;
        }

        [JsiiProperty(name: "requirements", typeJson: "{\"fqn\":\"stripe.person.PersonRequirementsOutputReference\"}")]
        public virtual stripe.Person.PersonRequirementsOutputReference Requirements
        {
            get => GetInstanceProperty<stripe.Person.PersonRequirementsOutputReference>()!;
        }

        [JsiiProperty(name: "ssnLast4Provided", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SsnLast4Provided
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "usCfpbData", typeJson: "{\"fqn\":\"stripe.person.PersonUsCfpbDataOutputReference\"}")]
        public virtual stripe.Person.PersonUsCfpbDataOutputReference UsCfpbData
        {
            get => GetInstanceProperty<stripe.Person.PersonUsCfpbDataOutputReference>()!;
        }

        [JsiiProperty(name: "verification", typeJson: "{\"fqn\":\"stripe.person.PersonVerificationOutputReference\"}")]
        public virtual stripe.Person.PersonVerificationOutputReference Verification
        {
            get => GetInstanceProperty<stripe.Person.PersonVerificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonAdditionalTosAcceptances" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalTosAcceptancesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonAdditionalTosAcceptances\"}]}}", isOptional: true)]
        public virtual object? AdditionalTosAcceptancesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonAddress\"}]}}", isOptional: true)]
        public virtual object? AddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonAddressKana" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressKanaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonAddressKana\"}]}}", isOptional: true)]
        public virtual object? AddressKanaInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonAddressKanji" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addressKanjiInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonAddressKanji\"}]}}", isOptional: true)]
        public virtual object? AddressKanjiInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonDob" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dobInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonDob\"}]}}", isOptional: true)]
        public virtual object? DobInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonDocuments" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "documentsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonDocuments\"}]}}", isOptional: true)]
        public virtual object? DocumentsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirstNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstNameKanaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirstNameKanaInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firstNameKanjiInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirstNameKanjiInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fullNameAliasesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? FullNameAliasesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "genderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GenderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idNumberSecondaryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdNumberSecondaryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastNameKanaInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastNameKanaInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lastNameKanjiInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LastNameKanjiInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maidenNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaidenNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nationalityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NationalityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "personTokenInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PersonTokenInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "politicalExposureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PoliticalExposureInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonRegisteredAddress" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "registeredAddressInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonRegisteredAddress\"}]}}", isOptional: true)]
        public virtual object? RegisteredAddressInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonRelationship" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "relationshipInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonRelationship\"}]}}", isOptional: true)]
        public virtual object? RelationshipInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ssnLast4Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SsnLast4Input
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonUsCfpbData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usCfpbDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonUsCfpbData\"}]}}", isOptional: true)]
        public virtual object? UsCfpbDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.Person.IPersonVerification" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verificationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.person.PersonVerification\"}]}}", isOptional: true)]
        public virtual object? VerificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "account", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Account
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firstNameKana", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstNameKana
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firstNameKanji", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstNameKanji
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fullNameAliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] FullNameAliases
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gender", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Gender
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idNumberSecondary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdNumberSecondary
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastNameKana", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastNameKana
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lastNameKanji", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastNameKanji
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maidenName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaidenName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nationality", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Nationality
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "personToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PersonToken
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Phone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "politicalExposure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoliticalExposure
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ssnLast4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SsnLast4
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
