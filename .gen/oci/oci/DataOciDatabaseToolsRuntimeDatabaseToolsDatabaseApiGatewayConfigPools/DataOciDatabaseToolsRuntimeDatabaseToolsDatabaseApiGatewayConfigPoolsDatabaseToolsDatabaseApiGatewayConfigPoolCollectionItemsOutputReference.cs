using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPools
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPools.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolsDatabaseToolsDatabaseApiGatewayConfigPoolCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPools.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolsDatabaseToolsDatabaseApiGatewayConfigPoolCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolsDatabaseToolsDatabaseApiGatewayConfigPoolCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolsDatabaseToolsDatabaseApiGatewayConfigPoolCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolsDatabaseToolsDatabaseApiGatewayConfigPoolCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolsDatabaseToolsDatabaseApiGatewayConfigPoolCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "advancedProperties", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdvancedProperties
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "databaseActionsStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseActionsStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseToolsConnectionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsConnectionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseToolsDatabaseApiGatewayConfigId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseToolsDatabaseApiGatewayConfigId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "initialPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialPoolSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "jwtProfileAudience", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtProfileAudience
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jwtProfileIssuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtProfileIssuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jwtProfileJwkUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtProfileJwkUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jwtProfileRoleClaimName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JwtProfileRoleClaimName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPoolSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinPoolSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "poolRouteValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolRouteValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "restEnabledSqlStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RestEnabledSqlStatus
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

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPools.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolsDatabaseToolsDatabaseApiGatewayConfigPoolCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPools.IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolsDatabaseToolsDatabaseApiGatewayConfigPoolCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPools.IDataOciDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigPoolsDatabaseToolsDatabaseApiGatewayConfigPoolCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
