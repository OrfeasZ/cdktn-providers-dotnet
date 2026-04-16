using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayDomainRegistration
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactOutputReference), fullyQualifiedName: "scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayDomainRegistrationAdministrativeContactOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayDomainRegistrationAdministrativeContactOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayDomainRegistrationAdministrativeContactOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayDomainRegistrationAdministrativeContactOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addressLine1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressLine1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "addressLine2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressLine2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string City
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "companyIdentificationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompanyIdentificationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "companyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompanyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emailAlt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailAlt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "extensionEu", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionEuList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionEuList ExtensionEu
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionEuList>()!;
        }

        [JsiiProperty(name: "extensionFr", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrList\"}")]
        public virtual scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrList ExtensionFr
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContactExtensionFrList>()!;
        }

        [JsiiProperty(name: "extensionNl", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExtensionNl
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "faxNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaxNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firstname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Firstname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lang", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Lang
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Lastname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "legalForm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LegalForm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhoneNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resale", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Resale
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vatIdentificationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VatIdentificationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "whoisOptIn", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable WhoisOptIn
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "zip", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zip
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayDomainRegistration.DataScalewayDomainRegistrationAdministrativeContact\"}", isOptional: true)]
        public virtual scaleway.DataScalewayDomainRegistration.IDataScalewayDomainRegistrationAdministrativeContact? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayDomainRegistration.IDataScalewayDomainRegistrationAdministrativeContact?>();
            set => SetInstanceProperty(value);
        }
    }
}
