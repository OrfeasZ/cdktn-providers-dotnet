using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsMyOauth2ClientCredentials
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expiresOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpiresOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "isResetSecret", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsResetSecret
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsMetaList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
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

        [JsiiProperty(name: "scopes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsScopesList\"}")]
        public virtual oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsScopesList Scopes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsScopesList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsUserList\"}")]
        public virtual oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsUserList User
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentialsUserList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMyOauth2ClientCredentials.DataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentials\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsMyOauth2ClientCredentials.IDataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentials? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMyOauth2ClientCredentials.IDataOciIdentityDomainsMyOauth2ClientCredentialsMyOauth2ClientCredentials?>();
            set => SetInstanceProperty(value);
        }
    }
}
