using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayAuditTrailEvent
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayAuditTrailEvent.DataScalewayAuditTrailEventEventsOutputReference), fullyQualifiedName: "scaleway.dataScalewayAuditTrailEvent.DataScalewayAuditTrailEventEventsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayAuditTrailEventEventsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayAuditTrailEventEventsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayAuditTrailEventEventsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayAuditTrailEventEventsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locality", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Locality
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "methodName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MethodName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "principalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrincipalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recordedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestBody
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "requestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"scaleway.dataScalewayAuditTrailEvent.DataScalewayAuditTrailEventEventsResourcesList\"}")]
        public virtual scaleway.DataScalewayAuditTrailEvent.DataScalewayAuditTrailEventEventsResourcesList Resources
        {
            get => GetInstanceProperty<scaleway.DataScalewayAuditTrailEvent.DataScalewayAuditTrailEventEventsResourcesList>()!;
        }

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StatusCode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserAgent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayAuditTrailEvent.DataScalewayAuditTrailEventEvents\"}", isOptional: true)]
        public virtual scaleway.DataScalewayAuditTrailEvent.IDataScalewayAuditTrailEventEvents? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayAuditTrailEvent.IDataScalewayAuditTrailEventEvents?>();
            set => SetInstanceProperty(value);
        }
    }
}
