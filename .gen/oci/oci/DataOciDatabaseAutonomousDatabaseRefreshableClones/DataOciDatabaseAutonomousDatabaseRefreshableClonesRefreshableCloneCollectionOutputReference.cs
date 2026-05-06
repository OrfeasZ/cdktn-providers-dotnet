using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseAutonomousDatabaseRefreshableClones
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseAutonomousDatabaseRefreshableClones.DataOciDatabaseAutonomousDatabaseRefreshableClonesRefreshableCloneCollectionOutputReference), fullyQualifiedName: "oci.dataOciDatabaseAutonomousDatabaseRefreshableClones.DataOciDatabaseAutonomousDatabaseRefreshableClonesRefreshableCloneCollectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseAutonomousDatabaseRefreshableClonesRefreshableCloneCollectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseAutonomousDatabaseRefreshableClonesRefreshableCloneCollectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseAutonomousDatabaseRefreshableClonesRefreshableCloneCollectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseAutonomousDatabaseRefreshableClonesRefreshableCloneCollectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabaseRefreshableClones.DataOciDatabaseAutonomousDatabaseRefreshableClonesRefreshableCloneCollectionItemsList\"}")]
        public virtual oci.DataOciDatabaseAutonomousDatabaseRefreshableClones.DataOciDatabaseAutonomousDatabaseRefreshableClonesRefreshableCloneCollectionItemsList Items
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabaseRefreshableClones.DataOciDatabaseAutonomousDatabaseRefreshableClonesRefreshableCloneCollectionItemsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseAutonomousDatabaseRefreshableClones.DataOciDatabaseAutonomousDatabaseRefreshableClonesRefreshableCloneCollection\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseAutonomousDatabaseRefreshableClones.IDataOciDatabaseAutonomousDatabaseRefreshableClonesRefreshableCloneCollection? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseAutonomousDatabaseRefreshableClones.IDataOciDatabaseAutonomousDatabaseRefreshableClonesRefreshableCloneCollection?>();
            set => SetInstanceProperty(value);
        }
    }
}
