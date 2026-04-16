using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancerMonitors
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareLoadBalancerMonitors.DataCloudflareLoadBalancerMonitorsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancerMonitors.DataCloudflareLoadBalancerMonitorsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareLoadBalancerMonitorsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareLoadBalancerMonitorsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareLoadBalancerMonitorsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareLoadBalancerMonitorsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowInsecure", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowInsecure
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "consecutiveDown", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConsecutiveDown
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "consecutiveUp", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConsecutiveUp
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expectedBody", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpectedBody
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expectedCodes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpectedCodes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "followRedirects", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable FollowRedirects
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"cdktn.StringListMap\"}")]
        public virtual Io.Cdktn.StringListMap Header
        {
            get => GetInstanceProperty<Io.Cdktn.StringListMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Interval
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Method
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "probeZone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProbeZone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Retries
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerMonitors.DataCloudflareLoadBalancerMonitorsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareLoadBalancerMonitors.IDataCloudflareLoadBalancerMonitorsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerMonitors.IDataCloudflareLoadBalancerMonitorsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
