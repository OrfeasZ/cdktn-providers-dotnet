using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataSafeAuditEvents
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataSafeAuditEvents.DataOciDataSafeAuditEventsAuditEventCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataSafeAuditEvents.DataOciDataSafeAuditEventsAuditEventCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataSafeAuditEventsAuditEventCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataSafeAuditEventsAuditEventCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataSafeAuditEventsAuditEventCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataSafeAuditEventsAuditEventCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "actionTaken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionTaken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "applicationContexts", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationContexts
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "auditEventTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditEventTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "auditLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditLocation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "auditPolicies", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditPolicies
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "auditTrailId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditTrailId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "auditType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientHostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientProgram", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientProgram
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "commandParam", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommandParam
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "commandText", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommandText
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseUniqueName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseUniqueName
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

        [JsiiProperty(name: "errorCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eventName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "extendedEventAttributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExtendedEventAttributes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalUserId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalUserId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fgaPolicyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FgaPolicyName
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

        [JsiiProperty(name: "isAlerted", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAlerted
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectOwner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Operation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osTerminal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsTerminal
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerTargetDatabaseKey", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeerTargetDatabaseKey
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "targetClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetClass
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

        [JsiiProperty(name: "targetUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCollected", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCollected
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "trailSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrailSource
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataSafeAuditEvents.DataOciDataSafeAuditEventsAuditEventCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataSafeAuditEvents.IDataOciDataSafeAuditEventsAuditEventCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataSafeAuditEvents.IDataOciDataSafeAuditEventsAuditEventCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
