using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSecurityAssessmentSecurityFeatures
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeaturesSecurityFeatureCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeaturesSecurityFeatureCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSecurityAssessmentSecurityFeaturesSecurityFeatureCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSecurityAssessmentSecurityFeaturesSecurityFeatureCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSecurityAssessmentSecurityFeaturesSecurityFeatureCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSecurityAssessmentSecurityFeaturesSecurityFeatureCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "assessmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssessmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "columnEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ColumnEncryption
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseVault", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVault
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "externalAuthentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalAuthentication
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fineGrainedAudit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FineGrainedAudit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "globalAuthentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GlobalAuthentication
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkEncryption
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordAuthentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PasswordAuthentication
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privilegeAnalysis", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivilegeAnalysis
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tablespaceEncryption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TablespaceEncryption
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "traditionalAudit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TraditionalAudit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "unifiedAudit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnifiedAudit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSecurityAssessmentSecurityFeatures.DataOciDataSafeSecurityAssessmentSecurityFeaturesSecurityFeatureCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.IDataOciDataSafeSecurityAssessmentSecurityFeaturesSecurityFeatureCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSecurityAssessmentSecurityFeatures.IDataOciDataSafeSecurityAssessmentSecurityFeaturesSecurityFeatureCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
