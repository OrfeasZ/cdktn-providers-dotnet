using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiShieldOperation
{
    [JsiiClass(nativeType: typeof(cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesOutputReference), fullyQualifiedName: "cloudflare.apiShieldOperation.ApiShieldOperationFeaturesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiShieldOperationFeaturesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiShieldOperationFeaturesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiShieldOperationFeaturesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiShieldOperationFeaturesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "apiRouting", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesApiRoutingOutputReference\"}")]
        public virtual cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesApiRoutingOutputReference ApiRouting
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesApiRoutingOutputReference>()!;
        }

        [JsiiProperty(name: "confidenceIntervals", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsOutputReference\"}")]
        public virtual cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsOutputReference ConfidenceIntervals
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsOutputReference>()!;
        }

        [JsiiProperty(name: "parameterSchemas", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesParameterSchemasOutputReference\"}")]
        public virtual cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesParameterSchemasOutputReference ParameterSchemas
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesParameterSchemasOutputReference>()!;
        }

        [JsiiProperty(name: "schemaInfo", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesSchemaInfoOutputReference\"}")]
        public virtual cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesSchemaInfoOutputReference SchemaInfo
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesSchemaInfoOutputReference>()!;
        }

        [JsiiProperty(name: "thresholds", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesThresholdsOutputReference\"}")]
        public virtual cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesThresholdsOutputReference Thresholds
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesThresholdsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeatures\"}", isOptional: true)]
        public virtual cloudflare.ApiShieldOperation.IApiShieldOperationFeatures? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.IApiShieldOperationFeatures?>();
            set => SetInstanceProperty(value);
        }
    }
}
