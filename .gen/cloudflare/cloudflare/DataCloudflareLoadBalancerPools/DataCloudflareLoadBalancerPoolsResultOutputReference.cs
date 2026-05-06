using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancerPools
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareLoadBalancerPoolsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareLoadBalancerPoolsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareLoadBalancerPoolsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareLoadBalancerPoolsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "checkRegions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CheckRegions
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "disabledAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisabledAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latitude", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Latitude
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "loadShedding", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultLoadSheddingOutputReference\"}")]
        public virtual cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultLoadSheddingOutputReference LoadShedding
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultLoadSheddingOutputReference>()!;
        }

        [JsiiProperty(name: "longitude", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Longitude
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minimumOrigins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumOrigins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "monitor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Monitor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "monitorGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonitorGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Networks
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "notificationEmail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationEmail
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationFilter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultNotificationFilterOutputReference\"}")]
        public virtual cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultNotificationFilterOutputReference NotificationFilter
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultNotificationFilterOutputReference>()!;
        }

        [JsiiProperty(name: "origins", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultOriginsList\"}")]
        public virtual cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultOriginsList Origins
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultOriginsList>()!;
        }

        [JsiiProperty(name: "originSteering", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultOriginSteeringOutputReference\"}")]
        public virtual cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultOriginSteeringOutputReference OriginSteering
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResultOriginSteeringOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPools.DataCloudflareLoadBalancerPoolsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareLoadBalancerPools.IDataCloudflareLoadBalancerPoolsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPools.IDataCloudflareLoadBalancerPoolsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
