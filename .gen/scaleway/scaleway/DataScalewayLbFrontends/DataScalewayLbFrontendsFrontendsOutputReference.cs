using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayLbFrontends
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayLbFrontends.DataScalewayLbFrontendsFrontendsOutputReference), fullyQualifiedName: "scaleway.dataScalewayLbFrontends.DataScalewayLbFrontendsFrontendsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayLbFrontendsFrontendsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayLbFrontendsFrontendsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayLbFrontendsFrontendsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayLbFrontendsFrontendsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backendId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackendId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CertificateIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "connectionRateLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectionRateLimit
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enableAccessLogs", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableAccessLogs
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableHttp3", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableHttp3
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inboundPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InboundPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lbId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LbId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeoutClient", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeoutClient
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updateAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdateAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbFrontends.DataScalewayLbFrontendsFrontends\"}", isOptional: true)]
        public virtual scaleway.DataScalewayLbFrontends.IDataScalewayLbFrontendsFrontends? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbFrontends.IDataScalewayLbFrontendsFrontends?>();
            set => SetInstanceProperty(value);
        }
    }
}
