using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciWaasWaasPolicy
{
    [JsiiClass(nativeType: typeof(oci.DataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigProtectionSettingsOutputReference), fullyQualifiedName: "oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigProtectionSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciWaasWaasPolicyWafConfigProtectionSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciWaasWaasPolicyWafConfigProtectionSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciWaasWaasPolicyWafConfigProtectionSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciWaasWaasPolicyWafConfigProtectionSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowedHttpMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedHttpMethods
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "blockAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockErrorPageCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockErrorPageCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockErrorPageDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockErrorPageDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockErrorPageMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockErrorPageMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "blockResponseCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BlockResponseCode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isResponseInspected", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsResponseInspected
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "maxArgumentCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxArgumentCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxNameLengthPerArgument", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxNameLengthPerArgument
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxResponseSizeInKiB", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxResponseSizeInKiB
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxTotalNameLengthOfArguments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTotalNameLengthOfArguments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mediaTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MediaTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "recommendationsPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecommendationsPeriodInDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciWaasWaasPolicy.DataOciWaasWaasPolicyWafConfigProtectionSettings\"}", isOptional: true)]
        public virtual oci.DataOciWaasWaasPolicy.IDataOciWaasWaasPolicyWafConfigProtectionSettings? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciWaasWaasPolicy.IDataOciWaasWaasPolicyWafConfigProtectionSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
