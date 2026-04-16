using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesRouteStage
{
    [JsiiClass(nativeType: typeof(scaleway.EdgeServicesRouteStage.EdgeServicesRouteStageRuleOutputReference), fullyQualifiedName: "scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EdgeServicesRouteStageRuleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public EdgeServicesRouteStageRuleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected EdgeServicesRouteStageRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EdgeServicesRouteStageRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRuleHttpMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatch\"}}]")]
        public virtual void PutRuleHttpMatch(scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackendStageId")]
        public virtual void ResetBackendStageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuleHttpMatch")]
        public virtual void ResetRuleHttpMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWafStageId")]
        public virtual void ResetWafStageId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ruleHttpMatch", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchOutputReference\"}")]
        public virtual scaleway.EdgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchOutputReference RuleHttpMatch
        {
            get => GetInstanceProperty<scaleway.EdgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendStageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackendStageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleHttpMatchInput", typeJson: "{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRuleRuleHttpMatch\"}", isOptional: true)]
        public virtual scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatch? RuleHttpMatchInput
        {
            get => GetInstanceProperty<scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRuleRuleHttpMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "wafStageIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WafStageIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "backendStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackendStageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "wafStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WafStageId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.edgeServicesRouteStage.EdgeServicesRouteStageRule\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.EdgeServicesRouteStage.IEdgeServicesRouteStageRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
