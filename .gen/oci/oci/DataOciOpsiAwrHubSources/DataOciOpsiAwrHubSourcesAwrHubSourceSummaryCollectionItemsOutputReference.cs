using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiAwrHubSources
{
    [JsiiClass(nativeType: typeof(oci.DataOciOpsiAwrHubSources.DataOciOpsiAwrHubSourcesAwrHubSourceSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOpsiAwrHubSources.DataOciOpsiAwrHubSourcesAwrHubSourceSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOpsiAwrHubSourcesAwrHubSourceSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOpsiAwrHubSourcesAwrHubSourceSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOpsiAwrHubSourcesAwrHubSourceSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiAwrHubSourcesAwrHubSourceSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associatedOpsiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedOpsiId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "associatedResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociatedResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "awrHubId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwrHubId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "awrHubOpsiSourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwrHubOpsiSourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "awrSourceDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwrSourceDatabaseId
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

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "hoursSinceLastImport", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HoursSinceLastImport
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isRegisteredWithAwrHub", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRegisteredWithAwrHub
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maxSnapshotIdentifier", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSnapshotIdentifier
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minSnapshotIdentifier", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinSnapshotIdentifier
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceMailBoxUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceMailBoxUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFirstSnapshotGenerated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFirstSnapshotGenerated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastSnapshotGenerated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastSnapshotGenerated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOpsiAwrHubSources.DataOciOpsiAwrHubSourcesAwrHubSourceSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOpsiAwrHubSources.IDataOciOpsiAwrHubSourcesAwrHubSourceSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOpsiAwrHubSources.IDataOciOpsiAwrHubSourcesAwrHubSourceSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
