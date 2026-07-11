using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermManagedRedis
{
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermManagedRedis.DataAzurermManagedRedisDefaultDatabaseOutputReference), fullyQualifiedName: "azurerm.dataAzurermManagedRedis.DataAzurermManagedRedisDefaultDatabaseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAzurermManagedRedisDefaultDatabaseOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAzurermManagedRedisDefaultDatabaseOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAzurermManagedRedisDefaultDatabaseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermManagedRedisDefaultDatabaseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessKeysAuthenticationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AccessKeysAuthenticationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clientProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusteringPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusteringPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "evictionPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EvictionPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "geoReplicationGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GeoReplicationGroupName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "geoReplicationLinkedDatabaseIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GeoReplicationLinkedDatabaseIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "module", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedRedis.DataAzurermManagedRedisDefaultDatabaseModuleList\"}")]
        public virtual azurerm.DataAzurermManagedRedis.DataAzurermManagedRedisDefaultDatabaseModuleList Module
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedRedis.DataAzurermManagedRedisDefaultDatabaseModuleList>()!;
        }

        [JsiiProperty(name: "persistenceAppendOnlyFileBackupFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PersistenceAppendOnlyFileBackupFrequency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "persistenceRedisDatabaseBackupFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PersistenceRedisDatabaseBackupFrequency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "primaryAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryAccessKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondaryAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryAccessKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.dataAzurermManagedRedis.DataAzurermManagedRedisDefaultDatabase\"}", isOptional: true)]
        public virtual azurerm.DataAzurermManagedRedis.IDataAzurermManagedRedisDefaultDatabase? InternalValue
        {
            get => GetInstanceProperty<azurerm.DataAzurermManagedRedis.IDataAzurermManagedRedisDefaultDatabase?>();
            set => SetInstanceProperty(value);
        }
    }
}
