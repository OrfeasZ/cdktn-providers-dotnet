using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZoneTracingRules
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZoneTracingRules.DataCloudflareZoneTracingRulesRulesActionParametersOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZoneTracingRules.DataCloudflareZoneTracingRulesRulesActionParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZoneTracingRulesRulesActionParametersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZoneTracingRulesRulesActionParametersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZoneTracingRulesRulesActionParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZoneTracingRulesRulesActionParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "samplingRatio", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SamplingRatio
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZoneTracingRules.DataCloudflareZoneTracingRulesRulesActionParameters\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZoneTracingRules.IDataCloudflareZoneTracingRulesRulesActionParameters? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZoneTracingRules.IDataCloudflareZoneTracingRulesRulesActionParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
