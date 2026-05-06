using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsSecurityQuestionSettings
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "maxFieldLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxFieldLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsMetaList>()!;
        }

        [JsiiProperty(name: "minAnswerLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinAnswerLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "numQuestionsToAns", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumQuestionsToAns
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "numQuestionsToSetup", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumQuestionsToSetup
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "securityQuestionSettingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityQuestionSettingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettingsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsSecurityQuestionSettings.DataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettings\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsSecurityQuestionSettings.IDataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsSecurityQuestionSettings.IDataOciIdentityDomainsSecurityQuestionSettingsSecurityQuestionSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
