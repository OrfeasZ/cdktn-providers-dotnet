using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_oci_console_sign_on_policy_consent oci_identity_domains_oci_console_sign_on_policy_consent}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent), fullyQualifiedName: "oci.dataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentConfig\"}}]")]
    public class DataOciIdentityDomainsOciConsoleSignOnPolicyConsent : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_oci_console_sign_on_policy_consent oci_identity_domains_oci_console_sign_on_policy_consent} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciIdentityDomainsOciConsoleSignOnPolicyConsent(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.IDataOciIdentityDomainsOciConsoleSignOnPolicyConsentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.IDataOciIdentityDomainsOciConsoleSignOnPolicyConsentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsOciConsoleSignOnPolicyConsent(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsOciConsoleSignOnPolicyConsent(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciIdentityDomainsOciConsoleSignOnPolicyConsent resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciIdentityDomainsOciConsoleSignOnPolicyConsent to import.</param>
        /// <param name="importFromId">The id of the existing DataOciIdentityDomainsOciConsoleSignOnPolicyConsent that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciIdentityDomainsOciConsoleSignOnPolicyConsent to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciIdentityDomainsOciConsoleSignOnPolicyConsent to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/identity_domains_oci_console_sign_on_policy_consent#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciIdentityDomainsOciConsoleSignOnPolicyConsent that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciIdentityDomainsOciConsoleSignOnPolicyConsent to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent))!;

        [JsiiProperty(name: "changeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChangeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consentSignedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentConsentSignedByList\"}")]
        public virtual oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentConsentSignedByList ConsentSignedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentConsentSignedByList>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "justification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Justification
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentMetaList>()!;
        }

        [JsiiProperty(name: "modifiedResource", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentModifiedResourceList\"}")]
        public virtual oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentModifiedResourceList ModifiedResource
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentModifiedResourceList>()!;
        }

        [JsiiProperty(name: "notificationRecipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NotificationRecipients
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policyResource", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentPolicyResourceList\"}")]
        public virtual oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentPolicyResourceList PolicyResource
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentPolicyResourceList>()!;
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

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsOciConsoleSignOnPolicyConsent.DataOciIdentityDomainsOciConsoleSignOnPolicyConsentTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeConsentSigned", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeConsentSigned
        {
            get => GetInstanceProperty<string>()!;
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
        [JsiiProperty(name: "ociConsoleSignOnPolicyConsentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OciConsoleSignOnPolicyConsentIdInput
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

        [JsiiProperty(name: "ociConsoleSignOnPolicyConsentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciConsoleSignOnPolicyConsentId
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
