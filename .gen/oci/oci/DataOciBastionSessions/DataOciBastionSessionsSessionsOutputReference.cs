using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciBastionSessions
{
    [JsiiClass(nativeType: typeof(oci.DataOciBastionSessions.DataOciBastionSessionsSessionsOutputReference), fullyQualifiedName: "oci.dataOciBastionSessions.DataOciBastionSessionsSessionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciBastionSessionsSessionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciBastionSessionsSessionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciBastionSessionsSessionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciBastionSessionsSessionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bastionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BastionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bastionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BastionName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bastionPublicHostKeyInfo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BastionPublicHostKeyInfo
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "bastionUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BastionUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyDetails", typeJson: "{\"fqn\":\"oci.dataOciBastionSessions.DataOciBastionSessionsSessionsKeyDetailsList\"}")]
        public virtual oci.DataOciBastionSessions.DataOciBastionSessionsSessionsKeyDetailsList KeyDetails
        {
            get => GetInstanceProperty<oci.DataOciBastionSessions.DataOciBastionSessionsSessionsKeyDetailsList>()!;
        }

        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sessionTtlInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SessionTtlInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sshMetadata", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SshMetadata
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetResourceDetails", typeJson: "{\"fqn\":\"oci.dataOciBastionSessions.DataOciBastionSessionsSessionsTargetResourceDetailsList\"}")]
        public virtual oci.DataOciBastionSessions.DataOciBastionSessionsSessionsTargetResourceDetailsList TargetResourceDetails
        {
            get => GetInstanceProperty<oci.DataOciBastionSessions.DataOciBastionSessionsSessionsTargetResourceDetailsList>()!;
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciBastionSessions.DataOciBastionSessionsSessions\"}", isOptional: true)]
        public virtual oci.DataOciBastionSessions.IDataOciBastionSessionsSessions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciBastionSessions.IDataOciBastionSessionsSessions?>();
            set => SetInstanceProperty(value);
        }
    }
}
