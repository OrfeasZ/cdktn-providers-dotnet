using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareLoadBalancerPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancer_pool cloudflare_load_balancer_pool}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPool), fullyQualifiedName: "cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolConfig\"}}]")]
    public class DataCloudflareLoadBalancerPool : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancer_pool cloudflare_load_balancer_pool} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareLoadBalancerPool(Constructs.Construct scope, string id, cloudflare.DataCloudflareLoadBalancerPool.IDataCloudflareLoadBalancerPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareLoadBalancerPool.IDataCloudflareLoadBalancerPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareLoadBalancerPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareLoadBalancerPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareLoadBalancerPool resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareLoadBalancerPool to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareLoadBalancerPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareLoadBalancerPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareLoadBalancerPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/load_balancer_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareLoadBalancerPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareLoadBalancerPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolFilter\"}}]")]
        public virtual void PutFilter(cloudflare.DataCloudflareLoadBalancerPool.IDataCloudflareLoadBalancerPoolFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.DataCloudflareLoadBalancerPool.IDataCloudflareLoadBalancerPoolFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPoolId")]
        public virtual void ResetPoolId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPool))!;

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

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolFilterOutputReference\"}")]
        public virtual cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolFilterOutputReference Filter
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolFilterOutputReference>()!;
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

        [JsiiProperty(name: "loadShedding", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolLoadSheddingOutputReference\"}")]
        public virtual cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolLoadSheddingOutputReference LoadShedding
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolLoadSheddingOutputReference>()!;
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

        [JsiiProperty(name: "notificationFilter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolNotificationFilterOutputReference\"}")]
        public virtual cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolNotificationFilterOutputReference NotificationFilter
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolNotificationFilterOutputReference>()!;
        }

        [JsiiProperty(name: "origins", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolOriginsList\"}")]
        public virtual cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolOriginsList Origins
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolOriginsList>()!;
        }

        [JsiiProperty(name: "originSteering", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolOriginSteeringOutputReference\"}")]
        public virtual cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolOriginSteeringOutputReference OriginSteering
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolOriginSteeringOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.dataCloudflareLoadBalancerPool.DataCloudflareLoadBalancerPoolFilter\"}]}}", isOptional: true)]
        public virtual object? FilterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "poolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
