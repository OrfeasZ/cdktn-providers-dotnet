using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSubsettingPolicies
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSubsettingPolicies.DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSubsettingPolicies.DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "checkType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CheckType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "generateHealthReportTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GenerateHealthReportTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isRedoLoggingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRedoLoggingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRefreshStatsEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRefreshStatsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maskingPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaskingPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parallelDegree", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParallelDegree
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "postSubsettingScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostSubsettingScript
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preSubsettingScript", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreSubsettingScript
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recompile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Recompile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemaSource", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicies.DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItemsSchemaSourceList\"}")]
        public virtual oci.DataOciDataSafeSubsettingPolicies.DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItemsSchemaSourceList SchemaSource
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingPolicies.DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItemsSchemaSourceList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tablespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tablespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetCredentials", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicies.DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItemsTargetCredentialsList\"}")]
        public virtual oci.DataOciDataSafeSubsettingPolicies.DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItemsTargetCredentialsList TargetCredentials
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingPolicies.DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItemsTargetCredentialsList>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "unrelatedTablesAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnrelatedTablesAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSubsettingPolicies.DataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSubsettingPolicies.IDataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSubsettingPolicies.IDataOciDataSafeSubsettingPoliciesSubsettingPolicyCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
