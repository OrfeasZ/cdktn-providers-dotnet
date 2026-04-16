using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiShieldOperation
{
    [JsiiClass(nativeType: typeof(cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesThresholdsOutputReference), fullyQualifiedName: "cloudflare.apiShieldOperation.ApiShieldOperationFeaturesThresholdsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiShieldOperationFeaturesThresholdsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiShieldOperationFeaturesThresholdsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiShieldOperationFeaturesThresholdsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiShieldOperationFeaturesThresholdsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authIdTokens", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AuthIdTokens
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "dataPoints", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataPoints
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lastUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "p50", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double P50
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "p90", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double P90
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "p99", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double P99
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "periodSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PeriodSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "requests", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Requests
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "suggestedThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SuggestedThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesThresholds\"}", isOptional: true)]
        public virtual cloudflare.ApiShieldOperation.IApiShieldOperationFeaturesThresholds? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.IApiShieldOperationFeaturesThresholds?>();
            set => SetInstanceProperty(value);
        }
    }
}
