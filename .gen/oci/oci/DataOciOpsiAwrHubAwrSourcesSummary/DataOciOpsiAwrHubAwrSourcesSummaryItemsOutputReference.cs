using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOpsiAwrHubAwrSourcesSummary
{
    [JsiiClass(nativeType: typeof(oci.DataOciOpsiAwrHubAwrSourcesSummary.DataOciOpsiAwrHubAwrSourcesSummaryItemsOutputReference), fullyQualifiedName: "oci.dataOciOpsiAwrHubAwrSourcesSummary.DataOciOpsiAwrHubAwrSourcesSummaryItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOpsiAwrHubAwrSourcesSummaryItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOpsiAwrHubAwrSourcesSummaryItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOpsiAwrHubAwrSourcesSummaryItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOpsiAwrHubAwrSourcesSummaryItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "awrHubId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwrHubId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "awrSourceDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwrSourceDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hoursSinceLastImport", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HoursSinceLastImport
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "snapshotsUploaded", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SnapshotsUploaded
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOpsiAwrHubAwrSourcesSummary.DataOciOpsiAwrHubAwrSourcesSummaryItems\"}", isOptional: true)]
        public virtual oci.DataOciOpsiAwrHubAwrSourcesSummary.IDataOciOpsiAwrHubAwrSourcesSummaryItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOpsiAwrHubAwrSourcesSummary.IDataOciOpsiAwrHubAwrSourcesSummaryItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
