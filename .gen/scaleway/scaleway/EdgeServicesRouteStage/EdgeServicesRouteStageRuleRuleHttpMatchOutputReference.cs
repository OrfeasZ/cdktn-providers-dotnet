using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesRouteStage
{
    [JsiiClass(nativeType: typeof(scaleway.EdgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchOutputReference), fullyQualifiedName: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EdgeServicesRouteStageRuleRuleHttpMatchOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EdgeServicesRouteStageRuleRuleHttpMatchOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EdgeServicesRouteStageRuleRuleHttpMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EdgeServicesRouteStageRuleRuleHttpMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHostFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilter\"}}]")]
        public virtual void PutHostFilter(scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPathFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchPathFilter\"}}]")]
        public virtual void PutPathFilter(scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchPathFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchPathFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHostFilter")]
        public virtual void ResetHostFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMethodFilters")]
        public virtual void ResetMethodFilters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPathFilter")]
        public virtual void ResetPathFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "hostFilter", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilterOutputReference\"}")]
        public virtual scaleway.EdgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilterOutputReference HostFilter
        {
            get => GetInstanceProperty<scaleway.EdgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilterOutputReference>()!;
        }

        [JsiiProperty(name: "pathFilter", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchPathFilterOutputReference\"}")]
        public virtual scaleway.EdgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchPathFilterOutputReference PathFilter
        {
            get => GetInstanceProperty<scaleway.EdgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchPathFilterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostFilterInput", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchHostFilter\"}", isOptional: true)]
        public virtual scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter? HostFilterInput
        {
            get => GetInstanceProperty<scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchHostFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "methodFiltersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? MethodFiltersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathFilterInput", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchPathFilter\"}", isOptional: true)]
        public virtual scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchPathFilter? PathFilterInput
        {
            get => GetInstanceProperty<scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatchPathFilter?>();
        }

        [JsiiProperty(name: "methodFilters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] MethodFilters
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatch\"}", isOptional: true)]
        public virtual scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatch? InternalValue
        {
            get => GetInstanceProperty<scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
