using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOspGatewaySubscription
{
    [JsiiClass(nativeType: typeof(oci.DataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionBillingAddressOutputReference), fullyQualifiedName: "oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionBillingAddressOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOspGatewaySubscriptionSubscriptionBillingAddressOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOspGatewaySubscriptionSubscriptionBillingAddressOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOspGatewaySubscriptionSubscriptionBillingAddressOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOspGatewaySubscriptionSubscriptionBillingAddressOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addressKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AddressKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string City
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "companyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompanyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contributorClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContributorClass
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Country
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "county", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string County
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "departmentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DepartmentName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirstName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "internalNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InternalNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobTitle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "line1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "line2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "line3", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line3
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "line4", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Line4
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "middleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MiddleName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "municipalInscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MunicipalInscription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phoneCountryCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhoneCountryCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhoneNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostalCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "province", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Province
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stateInscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateInscription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreetName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streetNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreetNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOspGatewaySubscription.DataOciOspGatewaySubscriptionSubscriptionBillingAddress\"}", isOptional: true)]
        public virtual oci.DataOciOspGatewaySubscription.IDataOciOspGatewaySubscriptionSubscriptionBillingAddress? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOspGatewaySubscription.IDataOciOspGatewaySubscriptionSubscriptionBillingAddress?>();
            set => SetInstanceProperty(value);
        }
    }
}
