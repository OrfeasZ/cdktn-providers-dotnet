using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeSqlFirewallViolationAnalytics
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeSqlFirewallViolationAnalytics.DataOciDataSafeSqlFirewallViolationAnalyticsSqlFirewallViolationAnalyticsCollectionItemsDimensionsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeSqlFirewallViolationAnalytics.DataOciDataSafeSqlFirewallViolationAnalyticsSqlFirewallViolationAnalyticsCollectionItemsDimensionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeSqlFirewallViolationAnalyticsSqlFirewallViolationAnalyticsCollectionItemsDimensionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeSqlFirewallViolationAnalyticsSqlFirewallViolationAnalyticsCollectionItemsDimensionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeSqlFirewallViolationAnalyticsSqlFirewallViolationAnalyticsCollectionItemsDimensionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeSqlFirewallViolationAnalyticsSqlFirewallViolationAnalyticsCollectionItemsDimensionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clientIp", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ClientIp
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "clientOsUserName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ClientOsUserName
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "clientProgram", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ClientProgram
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "dbUserName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DbUserName
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "operation", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Operation
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "operationTime", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OperationTime
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sqlLevel", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SqlLevel
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetId
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "targetName", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetName
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "violationAction", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ViolationAction
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "violationCause", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ViolationCause
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeSqlFirewallViolationAnalytics.DataOciDataSafeSqlFirewallViolationAnalyticsSqlFirewallViolationAnalyticsCollectionItemsDimensions\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeSqlFirewallViolationAnalytics.IDataOciDataSafeSqlFirewallViolationAnalyticsSqlFirewallViolationAnalyticsCollectionItemsDimensions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeSqlFirewallViolationAnalytics.IDataOciDataSafeSqlFirewallViolationAnalyticsSqlFirewallViolationAnalyticsCollectionItemsDimensions?>();
            set => SetInstanceProperty(value);
        }
    }
}
