using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesRouteStage
{
    [JsiiClass(nativeType: typeof(scaleway.EdgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilterOutputReference), fullyQualifiedName: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EdgeServicesRouteStageRuleRuleHttpMatchHostFilterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EdgeServicesRouteStageRuleRuleHttpMatchHostFilterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EdgeServicesRouteStageRuleRuleHttpMatchHostFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EdgeServicesRouteStageRuleRuleHttpMatchHostFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostFilterTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostFilterTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hostFilterType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostFilterType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Value
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilter\"}", isOptional: true)]
        public virtual scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter? InternalValue
        {
            get => GetInstanceProperty<scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}
