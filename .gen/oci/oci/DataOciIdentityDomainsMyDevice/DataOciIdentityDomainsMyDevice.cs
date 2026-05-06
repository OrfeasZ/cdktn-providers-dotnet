using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsMyDevice
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_device oci_identity_domains_my_device}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDevice), fullyQualifiedName: "oci.dataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDevice", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceConfig\"}}]")]
    public class DataOciIdentityDomainsMyDevice : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_device oci_identity_domains_my_device} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciIdentityDomainsMyDevice(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsMyDevice.IDataOciIdentityDomainsMyDeviceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsMyDevice.IDataOciIdentityDomainsMyDeviceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsMyDevice(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsMyDevice(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciIdentityDomainsMyDevice resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciIdentityDomainsMyDevice to import.</param>
        /// <param name="importFromId">The id of the existing DataOciIdentityDomainsMyDevice that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciIdentityDomainsMyDevice to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciIdentityDomainsMyDevice to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_my_device#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciIdentityDomainsMyDevice that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciIdentityDomainsMyDevice to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDevice), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAttributes")]
        public virtual void ResetAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttributeSets")]
        public virtual void ResetAttributeSets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypeSchemaVersion")]
        public virtual void ResetResourceTypeSchemaVersion()
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
        = GetStaticProperty<string>(typeof(oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDevice))!;

        [JsiiProperty(name: "additionalAttributes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceAdditionalAttributesList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceAdditionalAttributesList AdditionalAttributes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceAdditionalAttributesList>()!;
        }

        [JsiiProperty(name: "appVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authenticationFactors", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceAuthenticationFactorsList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceAuthenticationFactorsList AuthenticationFactors
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceAuthenticationFactorsList>()!;
        }

        [JsiiProperty(name: "authenticationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationMethod
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

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceMetaList>()!;
        }

        [JsiiProperty(name: "nonCompliances", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceNonCompliancesList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceNonCompliancesList NonCompliances
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceNonCompliancesList>()!;
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

        [JsiiProperty(name: "pushNotificationTarget", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDevicePushNotificationTargetList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDevicePushNotificationTargetList PushNotificationTarget
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDevicePushNotificationTargetList>()!;
        }

        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reason
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

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "thirdPartyFactor", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceThirdPartyFactorList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceThirdPartyFactorList ThirdPartyFactor
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceThirdPartyFactorList>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceUserList\"}")]
        public virtual oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceUserList User
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyDevice.DataOciIdentityDomainsMyDeviceUserList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeSetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AttributeSetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttributesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsEndpointInput
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
        [JsiiProperty(name: "myDeviceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MyDeviceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
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

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "myDeviceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MyDeviceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
