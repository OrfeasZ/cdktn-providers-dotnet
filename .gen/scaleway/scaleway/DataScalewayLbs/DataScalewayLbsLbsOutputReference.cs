using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayLbs
{
    [JsiiClass(nativeType: typeof(scaleway.DataScalewayLbs.DataScalewayLbsLbsOutputReference), fullyQualifiedName: "scaleway.dataScalewayLbs.DataScalewayLbsLbsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataScalewayLbsLbsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataScalewayLbsLbsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataScalewayLbsLbsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataScalewayLbsLbsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backendCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackendCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "frontendCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FrontendCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instances", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbs.DataScalewayLbsLbsInstancesList\"}")]
        public virtual scaleway.DataScalewayLbs.DataScalewayLbsLbsInstancesList Instances
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbs.DataScalewayLbsLbsInstancesList>()!;
        }

        [JsiiProperty(name: "ips", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbs.DataScalewayLbsLbsIpsList\"}")]
        public virtual scaleway.DataScalewayLbs.DataScalewayLbsLbsIpsList Ips
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbs.DataScalewayLbsLbsIpsList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateNetworkCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PrivateNetworkCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RouteCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sslCompatibilityLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslCompatibilityLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscriber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subscriber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.dataScalewayLbs.DataScalewayLbsLbs\"}", isOptional: true)]
        public virtual scaleway.DataScalewayLbs.IDataScalewayLbsLbs? InternalValue
        {
            get => GetInstanceProperty<scaleway.DataScalewayLbs.IDataScalewayLbsLbs?>();
            set => SetInstanceProperty(value);
        }
    }
}
