using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSqlFirewallAllowedSqls
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSqlFirewallAllowedSqls.DataOciDataSafeSqlFirewallAllowedSqlsSqlFirewallAllowedSqlCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSqlFirewallAllowedSqls.DataOciDataSafeSqlFirewallAllowedSqlsSqlFirewallAllowedSqlCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSqlFirewallAllowedSqlsSqlFirewallAllowedSqlCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSqlFirewallAllowedSqlsSqlFirewallAllowedSqlCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSqlFirewallAllowedSqlsSqlFirewallAllowedSqlCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSqlFirewallAllowedSqlsSqlFirewallAllowedSqlCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbUserName
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlAccessedObjects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SqlAccessedObjects
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sqlFirewallPolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlFirewallPolicyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCollected", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCollected
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSqlFirewallAllowedSqls.DataOciDataSafeSqlFirewallAllowedSqlsSqlFirewallAllowedSqlCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSqlFirewallAllowedSqls.IDataOciDataSafeSqlFirewallAllowedSqlsSqlFirewallAllowedSqlCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSqlFirewallAllowedSqls.IDataOciDataSafeSqlFirewallAllowedSqlsSqlFirewallAllowedSqlCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
