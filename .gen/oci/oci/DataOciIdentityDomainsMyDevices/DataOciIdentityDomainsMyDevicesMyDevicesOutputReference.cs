using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsMyDevices
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsMyDevicesMyDevicesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsMyDevicesMyDevicesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsMyDevicesMyDevicesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsMyDevicesMyDevicesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalAttributes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesAdditionalAttributesList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesAdditionalAttributesList AdditionalAttributes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesAdditionalAttributesList>()!;
        }

        [JsiiProperty(name: "appVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "authenticationFactors", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesAuthenticationFactorsList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesAuthenticationFactorsList AuthenticationFactors
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesAuthenticationFactorsList>()!;
        }

        [JsiiProperty(name: "authenticationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "basePublicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BasePublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CountryCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "deviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expiresOn", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpiresOn
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "isAccRecEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAccRecEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isCompliant", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCompliant
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lastSyncTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastSyncTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastValidatedTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastValidatedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesMetaList>()!;
        }

        [JsiiProperty(name: "myDeviceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MyDeviceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nonCompliances", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesNonCompliancesList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesNonCompliancesList NonCompliances
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesNonCompliancesList>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "packageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhoneNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Platform
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pushNotificationTarget", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesPushNotificationTargetList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesPushNotificationTargetList PushNotificationTarget
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesPushNotificationTargetList>()!;
        }

        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "seed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Seed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "seedDekId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SeedDekId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "thirdPartyFactor", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesThirdPartyFactorList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesThirdPartyFactorList ThirdPartyFactor
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesThirdPartyFactorList>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesUserList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesUserList User
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevicesUserList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevices.DataOciIdentityDomainsMyDevicesMyDevices\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsMyDevices.IDataOciIdentityDomainsMyDevicesMyDevices? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevices.IDataOciIdentityDomainsMyDevicesMyDevices?>();
            set => SetInstanceProperty(value);
        }
    }
}
