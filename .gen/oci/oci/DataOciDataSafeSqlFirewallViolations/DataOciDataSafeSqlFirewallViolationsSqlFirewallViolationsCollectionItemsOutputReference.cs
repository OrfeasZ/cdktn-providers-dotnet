using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSqlFirewallViolations
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSqlFirewallViolations.DataOciDataSafeSqlFirewallViolationsSqlFirewallViolationsCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSqlFirewallViolations.DataOciDataSafeSqlFirewallViolationsSqlFirewallViolationsCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSqlFirewallViolationsSqlFirewallViolationsCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSqlFirewallViolationsSqlFirewallViolationsCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSqlFirewallViolationsSqlFirewallViolationsCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSqlFirewallViolationsSqlFirewallViolationsCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clientIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientOsUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientOsUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientProgram", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientProgram
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentDbUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentDbUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sqlAccessedObjects", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlAccessedObjects
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

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCollected", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCollected
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "violationAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViolationAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "violationCause", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ViolationCause
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSqlFirewallViolations.DataOciDataSafeSqlFirewallViolationsSqlFirewallViolationsCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSqlFirewallViolations.IDataOciDataSafeSqlFirewallViolationsSqlFirewallViolationsCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSqlFirewallViolations.IDataOciDataSafeSqlFirewallViolationsSqlFirewallViolationsCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
