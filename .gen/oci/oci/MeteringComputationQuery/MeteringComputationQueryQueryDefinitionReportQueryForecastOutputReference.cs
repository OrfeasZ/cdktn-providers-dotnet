using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MeteringComputationQuery
{
    [JsiiClass(nativeType: typeof(oci.MeteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryForecastOutputReference), fullyQualifiedName: "oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryForecastOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MeteringComputationQueryQueryDefinitionReportQueryForecastOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MeteringComputationQueryQueryDefinitionReportQueryForecastOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MeteringComputationQueryQueryDefinitionReportQueryForecastOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MeteringComputationQueryQueryDefinitionReportQueryForecastOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetForecastType")]
        public virtual void ResetForecastType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeForecastStarted")]
        public virtual void ResetTimeForecastStarted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "forecastTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ForecastTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeForecastEndedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeForecastEndedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeForecastStartedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeForecastStartedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "forecastType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ForecastType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeForecastEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeForecastEnded
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeForecastStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeForecastStarted
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.meteringComputationQuery.MeteringComputationQueryQueryDefinitionReportQueryForecast\"}", isOptional: true)]
        public virtual oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQueryForecast? InternalValue
        {
            get => GetInstanceProperty<oci.MeteringComputationQuery.IMeteringComputationQueryQueryDefinitionReportQueryForecast?>();
            set => SetInstanceProperty(value);
        }
    }
}
