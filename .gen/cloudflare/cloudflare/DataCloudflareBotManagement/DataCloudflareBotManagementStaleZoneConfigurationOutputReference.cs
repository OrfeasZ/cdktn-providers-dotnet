using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareBotManagement
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareBotManagement.DataCloudflareBotManagementStaleZoneConfigurationOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareBotManagement.DataCloudflareBotManagementStaleZoneConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareBotManagementStaleZoneConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareBotManagementStaleZoneConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareBotManagementStaleZoneConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareBotManagementStaleZoneConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "fightMode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable FightMode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "optimizeWordpress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable OptimizeWordpress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "sbfmDefinitelyAutomated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SbfmDefinitelyAutomated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sbfmLikelyAutomated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SbfmLikelyAutomated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sbfmStaticResourceProtection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SbfmStaticResourceProtection
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sbfmVerifiedBots", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SbfmVerifiedBots
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "suppressSessionScore", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SuppressSessionScore
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareBotManagement.DataCloudflareBotManagementStaleZoneConfiguration\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareBotManagement.IDataCloudflareBotManagementStaleZoneConfiguration? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareBotManagement.IDataCloudflareBotManagementStaleZoneConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
