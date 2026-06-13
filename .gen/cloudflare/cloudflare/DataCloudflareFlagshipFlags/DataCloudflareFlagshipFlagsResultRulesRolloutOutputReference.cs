using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareFlagshipFlags
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareFlagshipFlags.DataCloudflareFlagshipFlagsResultRulesRolloutOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareFlagshipFlags.DataCloudflareFlagshipFlagsResultRulesRolloutOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareFlagshipFlagsResultRulesRolloutOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareFlagshipFlagsResultRulesRolloutOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareFlagshipFlagsResultRulesRolloutOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareFlagshipFlagsResultRulesRolloutOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "percentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Percentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareFlagshipFlags.DataCloudflareFlagshipFlagsResultRulesRollout\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareFlagshipFlags.IDataCloudflareFlagshipFlagsResultRulesRollout? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareFlagshipFlags.IDataCloudflareFlagshipFlagsResultRulesRollout?>();
            set => SetInstanceProperty(value);
        }
    }
}
