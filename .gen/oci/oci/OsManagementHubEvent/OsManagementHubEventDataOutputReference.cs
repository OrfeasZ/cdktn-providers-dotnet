using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubEvent
{
    [JsiiClass(nativeType: typeof(oci.OsManagementHubEvent.OsManagementHubEventDataOutputReference), fullyQualifiedName: "oci.osManagementHubEvent.OsManagementHubEventDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class OsManagementHubEventDataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public OsManagementHubEventDataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected OsManagementHubEventDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubEventDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalDetails", typeJson: "{\"fqn\":\"oci.osManagementHubEvent.OsManagementHubEventDataAdditionalDetailsList\"}")]
        public virtual oci.OsManagementHubEvent.OsManagementHubEventDataAdditionalDetailsList AdditionalDetails
        {
            get => GetInstanceProperty<oci.OsManagementHubEvent.OsManagementHubEventDataAdditionalDetailsList>()!;
        }

        [JsiiProperty(name: "attemptedResolutions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttemptedResolutions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"oci.osManagementHubEvent.OsManagementHubEventDataContentList\"}")]
        public virtual oci.OsManagementHubEvent.OsManagementHubEventDataContentList Content
        {
            get => GetInstanceProperty<oci.OsManagementHubEvent.OsManagementHubEventDataContentList>()!;
        }

        [JsiiProperty(name: "errorCause", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorCause
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorLog", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorLog
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eventCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EventCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "eventFingerprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventFingerprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HealthState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rebootStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RebootStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resolutionLog", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResolutionLog
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resolutionStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResolutionStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFirstOccurred", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFirstOccurred
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.osManagementHubEvent.OsManagementHubEventData\"}", isOptional: true)]
        public virtual oci.OsManagementHubEvent.IOsManagementHubEventData? InternalValue
        {
            get => GetInstanceProperty<oci.OsManagementHubEvent.IOsManagementHubEventData?>();
            set => SetInstanceProperty(value);
        }
    }
}
