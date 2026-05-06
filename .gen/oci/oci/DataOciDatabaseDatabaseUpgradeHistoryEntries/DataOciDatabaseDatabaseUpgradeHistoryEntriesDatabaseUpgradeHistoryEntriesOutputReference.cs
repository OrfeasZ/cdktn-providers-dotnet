using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseDatabaseUpgradeHistoryEntries
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseDatabaseUpgradeHistoryEntries.DataOciDatabaseDatabaseUpgradeHistoryEntriesDatabaseUpgradeHistoryEntriesOutputReference), fullyQualifiedName: "oci.dataOciDatabaseDatabaseUpgradeHistoryEntries.DataOciDatabaseDatabaseUpgradeHistoryEntriesDatabaseUpgradeHistoryEntriesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseDatabaseUpgradeHistoryEntriesDatabaseUpgradeHistoryEntriesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseDatabaseUpgradeHistoryEntriesDatabaseUpgradeHistoryEntriesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseDatabaseUpgradeHistoryEntriesDatabaseUpgradeHistoryEntriesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseDatabaseUpgradeHistoryEntriesDatabaseUpgradeHistoryEntriesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Action
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "options", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Options
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceDbHomeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDbHomeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetDatabaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetDatabaseSoftwareImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetDbHomeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetDbHomeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetDbVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetDbVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseDatabaseUpgradeHistoryEntries.DataOciDatabaseDatabaseUpgradeHistoryEntriesDatabaseUpgradeHistoryEntries\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseDatabaseUpgradeHistoryEntries.IDataOciDatabaseDatabaseUpgradeHistoryEntriesDatabaseUpgradeHistoryEntries? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseDatabaseUpgradeHistoryEntries.IDataOciDatabaseDatabaseUpgradeHistoryEntriesDatabaseUpgradeHistoryEntries?>();
            set => SetInstanceProperty(value);
        }
    }
}
