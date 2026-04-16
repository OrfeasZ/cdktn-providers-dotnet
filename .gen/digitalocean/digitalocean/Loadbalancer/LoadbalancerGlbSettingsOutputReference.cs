using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.Loadbalancer
{
    [JsiiClass(nativeType: typeof(digitalocean.Loadbalancer.LoadbalancerGlbSettingsOutputReference), fullyQualifiedName: "digitalocean.loadbalancer.LoadbalancerGlbSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LoadbalancerGlbSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LoadbalancerGlbSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadbalancerGlbSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadbalancerGlbSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCdn", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerGlbSettingsCdn\"}}]")]
        public virtual void PutCdn(digitalocean.Loadbalancer.ILoadbalancerGlbSettingsCdn @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.Loadbalancer.ILoadbalancerGlbSettingsCdn)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCdn")]
        public virtual void ResetCdn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailoverThreshold")]
        public virtual void ResetFailoverThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegionPriorities")]
        public virtual void ResetRegionPriorities()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cdn", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerGlbSettingsCdnOutputReference\"}")]
        public virtual digitalocean.Loadbalancer.LoadbalancerGlbSettingsCdnOutputReference Cdn
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.LoadbalancerGlbSettingsCdnOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cdnInput", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerGlbSettingsCdn\"}", isOptional: true)]
        public virtual digitalocean.Loadbalancer.ILoadbalancerGlbSettingsCdn? CdnInput
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.ILoadbalancerGlbSettingsCdn?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failoverThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FailoverThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionPrioritiesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, double>? RegionPrioritiesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, double>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetProtocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "failoverThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailoverThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "regionPriorities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, double> RegionPriorities
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, double>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetProtocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.loadbalancer.LoadbalancerGlbSettings\"}", isOptional: true)]
        public virtual digitalocean.Loadbalancer.ILoadbalancerGlbSettings? InternalValue
        {
            get => GetInstanceProperty<digitalocean.Loadbalancer.ILoadbalancerGlbSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
