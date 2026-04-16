using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.EdgeServicesBackendStage
{
    [JsiiClass(nativeType: typeof(scaleway.EdgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfigOutputReference), fullyQualifiedName: "scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EdgeServicesBackendStageLbBackendConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public EdgeServicesBackendStageLbBackendConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected EdgeServicesBackendStageLbBackendConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EdgeServicesBackendStageLbBackendConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLbConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfigLbConfig\"}}]")]
        public virtual void PutLbConfig(scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfigLbConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfigLbConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLbConfig")]
        public virtual void ResetLbConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "lbConfig", typeJson: "{\"fqn\":\"scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfigLbConfigOutputReference\"}")]
        public virtual scaleway.EdgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfigLbConfigOutputReference LbConfig
        {
            get => GetInstanceProperty<scaleway.EdgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfigLbConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "lbConfigInput", typeJson: "{\"fqn\":\"scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfigLbConfig\"}", isOptional: true)]
        public virtual scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfigLbConfig? LbConfigInput
        {
            get => GetInstanceProperty<scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfigLbConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"scaleway.edgeServicesBackendStage.EdgeServicesBackendStageLbBackendConfig\"}]}}", isOptional: true)]
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
                        case scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfig cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.EdgeServicesBackendStage.IEdgeServicesBackendStageLbBackendConfig).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
