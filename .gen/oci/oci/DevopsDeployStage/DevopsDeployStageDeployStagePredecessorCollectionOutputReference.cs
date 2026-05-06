using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiClass(nativeType: typeof(oci.DevopsDeployStage.DevopsDeployStageDeployStagePredecessorCollectionOutputReference), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageDeployStagePredecessorCollectionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DevopsDeployStageDeployStagePredecessorCollectionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DevopsDeployStageDeployStagePredecessorCollectionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DevopsDeployStageDeployStagePredecessorCollectionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsDeployStageDeployStagePredecessorCollectionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putItems", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageDeployStagePredecessorCollectionItems\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutItems(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DevopsDeployStage.IDevopsDeployStageDeployStagePredecessorCollectionItems[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DevopsDeployStage.IDevopsDeployStageDeployStagePredecessorCollectionItems).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DevopsDeployStage.IDevopsDeployStageDeployStagePredecessorCollectionItems).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "items", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageDeployStagePredecessorCollectionItemsList\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageDeployStagePredecessorCollectionItemsList Items
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageDeployStagePredecessorCollectionItemsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "itemsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageDeployStagePredecessorCollectionItems\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ItemsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageDeployStagePredecessorCollection\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageDeployStagePredecessorCollection? InternalValue
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageDeployStagePredecessorCollection?>();
            set => SetInstanceProperty(value);
        }
    }
}
