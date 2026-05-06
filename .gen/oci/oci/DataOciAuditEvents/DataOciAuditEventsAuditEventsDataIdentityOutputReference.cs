using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAuditEvents
{
    [JsiiClass(nativeType: typeof(oci.DataOciAuditEvents.DataOciAuditEventsAuditEventsDataIdentityOutputReference), fullyQualifiedName: "oci.dataOciAuditEvents.DataOciAuditEventsAuditEventsDataIdentityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAuditEventsAuditEventsDataIdentityOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAuditEventsAuditEventsDataIdentityOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciAuditEventsAuditEventsDataIdentityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAuditEventsAuditEventsDataIdentityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "callerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CallerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "callerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CallerName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consoleSessionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsoleSessionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Credentials
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "principalName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserAgent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAuditEvents.DataOciAuditEventsAuditEventsDataIdentity\"}", isOptional: true)]
        public virtual oci.DataOciAuditEvents.IDataOciAuditEventsAuditEventsDataIdentity? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAuditEvents.IDataOciAuditEventsAuditEventsDataIdentity?>();
            set => SetInstanceProperty(value);
        }
    }
}
