using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewayAddressActionVerification
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_address_action_verification oci_osp_gateway_address_action_verification}.</summary>
    [JsiiClass(nativeType: typeof(oci.OspGatewayAddressActionVerification.OspGatewayAddressActionVerification), fullyQualifiedName: "oci.ospGatewayAddressActionVerification.OspGatewayAddressActionVerification", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.ospGatewayAddressActionVerification.OspGatewayAddressActionVerificationConfig\"}}]")]
    public class OspGatewayAddressActionVerification : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_address_action_verification oci_osp_gateway_address_action_verification} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OspGatewayAddressActionVerification(Constructs.Construct scope, string id, oci.OspGatewayAddressActionVerification.IOspGatewayAddressActionVerificationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OspGatewayAddressActionVerification.IOspGatewayAddressActionVerificationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OspGatewayAddressActionVerification(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OspGatewayAddressActionVerification(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OspGatewayAddressActionVerification resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OspGatewayAddressActionVerification to import.</param>
        /// <param name="importFromId">The id of the existing OspGatewayAddressActionVerification that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OspGatewayAddressActionVerification to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OspGatewayAddressActionVerification to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_address_action_verification#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OspGatewayAddressActionVerification that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OspGatewayAddressActionVerification to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OspGatewayAddressActionVerification.OspGatewayAddressActionVerification), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.ospGatewayAddressActionVerification.OspGatewayAddressActionVerificationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OspGatewayAddressActionVerification.IOspGatewayAddressActionVerificationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OspGatewayAddressActionVerification.IOspGatewayAddressActionVerificationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAddressKey")]
        public virtual void ResetAddressKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCity")]
        public virtual void ResetCity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompanyName")]
        public virtual void ResetCompanyName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContributorClass")]
        public virtual void ResetContributorClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCountry")]
        public virtual void ResetCountry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCounty")]
        public virtual void ResetCounty()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDepartmentName")]
        public virtual void ResetDepartmentName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailAddress")]
        public virtual void ResetEmailAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirstName")]
        public virtual void ResetFirstName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInternalNumber")]
        public virtual void ResetInternalNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJobTitle")]
        public virtual void ResetJobTitle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLastName")]
        public virtual void ResetLastName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLine1")]
        public virtual void ResetLine1()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLine2")]
        public virtual void ResetLine2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLine3")]
        public virtual void ResetLine3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLine4")]
        public virtual void ResetLine4()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMiddleName")]
        public virtual void ResetMiddleName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMunicipalInscription")]
        public virtual void ResetMunicipalInscription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhoneCountryCode")]
        public virtual void ResetPhoneCountryCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhoneNumber")]
        public virtual void ResetPhoneNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostalCode")]
        public virtual void ResetPostalCode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProvince")]
        public virtual void ResetProvince()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetState")]
        public virtual void ResetState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStateInscription")]
        public virtual void ResetStateInscription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreetName")]
        public virtual void ResetStreetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreetNumber")]
        public virtual void ResetStreetNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(oci.OspGatewayAddressActionVerification.OspGatewayAddressActionVerification))!;

        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"oci.ospGatewayAddressActionVerification.OspGatewayAddressActionVerificationAddressList\"}")]
        public virtual oci.OspGatewayAddressActionVerification.OspGatewayAddressActionVerificationAddressList Address
        {
            get => GetInstanceProperty<oci.OspGatewayAddressActionVerification.OspGatewayAddressActionVerificationAddressList>()!;
        }

        [JsiiProperty(name: "quality", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Quality
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.ospGatewayAddressActionVerification.OspGatewayAddressActionVerificationTimeoutsOutputReference\"}")]
        public virtual oci.OspGatewayAddressActionVerification.OspGatewayAddressActionVerificationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OspGatewayAddressActionVerification.OspGatewayAddressActionVerificationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "verificationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerificationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addressKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AddressKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "companyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompanyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contributorClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContributorClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "countryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CountryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "countyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CountyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "departmentNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DepartmentNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailAddressInput
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
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InternalNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobTitleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobTitleInput
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
        [JsiiProperty(name: "line1Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Line1Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "line2Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Line2Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "line3Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Line3Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "line4Input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Line4Input
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "middleNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MiddleNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "municipalInscriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MunicipalInscriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ospHomeRegionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OspHomeRegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phoneCountryCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhoneCountryCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "phoneNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhoneNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postalCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PostalCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "provinceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProvinceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stateInscriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StateInscriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreetNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streetNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StreetNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.ospGatewayAddressActionVerification.OspGatewayAddressActionVerificationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "addressKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string City
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "companyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompanyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contributorClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContributorClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "county", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string County
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "departmentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DepartmentName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailAddress
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "internalNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InternalNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jobTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobTitle
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

        [JsiiProperty(name: "line1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line1
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "line2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line2
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "line3", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line3
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "line4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line4
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "middleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MiddleName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "municipalInscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MunicipalInscription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ospHomeRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OspHomeRegion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "phoneCountryCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhoneCountryCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhoneNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostalCode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "province", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Province
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stateInscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateInscription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreetName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "streetNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreetNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
