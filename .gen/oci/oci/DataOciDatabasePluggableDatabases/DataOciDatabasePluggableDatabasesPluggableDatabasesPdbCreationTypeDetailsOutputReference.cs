using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabasePluggableDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabasePluggableDatabases.DataOciDatabasePluggableDatabasesPluggableDatabasesPdbCreationTypeDetailsOutputReference), fullyQualifiedName: "oci.dataOciDatabasePluggableDatabases.DataOciDatabasePluggableDatabasesPluggableDatabasesPdbCreationTypeDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabasePluggableDatabasesPluggableDatabasesPdbCreationTypeDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabasePluggableDatabasesPluggableDatabasesPdbCreationTypeDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabasePluggableDatabasesPluggableDatabasesPdbCreationTypeDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabasePluggableDatabasesPluggableDatabasesPdbCreationTypeDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "creationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dblinkUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DblinkUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dblinkUserPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DblinkUserPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isThinClone", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsThinClone
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "refreshableCloneDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabasePluggableDatabases.DataOciDatabasePluggableDatabasesPluggableDatabasesPdbCreationTypeDetailsRefreshableCloneDetailsList\"}")]
        public virtual oci.DataOciDatabasePluggableDatabases.DataOciDatabasePluggableDatabasesPluggableDatabasesPdbCreationTypeDetailsRefreshableCloneDetailsList RefreshableCloneDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabasePluggableDatabases.DataOciDatabasePluggableDatabasesPluggableDatabasesPdbCreationTypeDetailsRefreshableCloneDetailsList>()!;
        }

        [JsiiProperty(name: "sourceContainerDatabaseAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceContainerDatabaseAdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourcePluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourcePluggableDatabaseId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourcePluggableDatabaseSnapshotId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourcePluggableDatabaseSnapshotId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabasePluggableDatabases.DataOciDatabasePluggableDatabasesPluggableDatabasesPdbCreationTypeDetails\"}", isOptional: true)]
        public virtual oci.DataOciDatabasePluggableDatabases.IDataOciDatabasePluggableDatabasesPluggableDatabasesPdbCreationTypeDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabasePluggableDatabases.IDataOciDatabasePluggableDatabasesPluggableDatabasesPdbCreationTypeDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
