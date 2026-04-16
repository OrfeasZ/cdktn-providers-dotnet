using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ArcregionswitchPlan
{
    [JsiiClass(nativeType: typeof(aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepOutputReference), fullyQualifiedName: "aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ArcregionswitchPlanWorkflowStepParallelConfigStepOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ArcregionswitchPlanWorkflowStepParallelConfigStepOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ArcregionswitchPlanWorkflowStepParallelConfigStepOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ArcregionswitchPlanWorkflowStepParallelConfigStepOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putArcRoutingControlConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutArcRoutingControlConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomActionLambdaConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomActionLambdaConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDocumentDbConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDocumentDbConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEc2AsgCapacityIncreaseConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEc2AsgCapacityIncreaseConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcsCapacityIncreaseConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEcsCapacityIncreaseConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEksResourceScalingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEksResourceScalingConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExecutionApprovalConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepExecutionApprovalConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExecutionApprovalConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepExecutionApprovalConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepExecutionApprovalConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepExecutionApprovalConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGlobalAuroraConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepGlobalAuroraConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGlobalAuroraConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepGlobalAuroraConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepGlobalAuroraConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepGlobalAuroraConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegionSwitchPlanConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRegionSwitchPlanConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRegionSwitchPlanConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRegionSwitchPlanConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRegionSwitchPlanConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRegionSwitchPlanConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoute53HealthCheckConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfig\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRoute53HealthCheckConfig(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfig[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfig).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfig).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetArcRoutingControlConfig")]
        public virtual void ResetArcRoutingControlConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomActionLambdaConfig")]
        public virtual void ResetCustomActionLambdaConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDocumentDbConfig")]
        public virtual void ResetDocumentDbConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2AsgCapacityIncreaseConfig")]
        public virtual void ResetEc2AsgCapacityIncreaseConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcsCapacityIncreaseConfig")]
        public virtual void ResetEcsCapacityIncreaseConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEksResourceScalingConfig")]
        public virtual void ResetEksResourceScalingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutionApprovalConfig")]
        public virtual void ResetExecutionApprovalConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGlobalAuroraConfig")]
        public virtual void ResetGlobalAuroraConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegionSwitchPlanConfig")]
        public virtual void ResetRegionSwitchPlanConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoute53HealthCheckConfig")]
        public virtual void ResetRoute53HealthCheckConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "arcRoutingControlConfig", typeJson: "{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfigList\"}")]
        public virtual aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfigList ArcRoutingControlConfig
        {
            get => GetInstanceProperty<aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfigList>()!;
        }

        [JsiiProperty(name: "customActionLambdaConfig", typeJson: "{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfigList\"}")]
        public virtual aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfigList CustomActionLambdaConfig
        {
            get => GetInstanceProperty<aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfigList>()!;
        }

        [JsiiProperty(name: "documentDbConfig", typeJson: "{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfigList\"}")]
        public virtual aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfigList DocumentDbConfig
        {
            get => GetInstanceProperty<aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfigList>()!;
        }

        [JsiiProperty(name: "ec2AsgCapacityIncreaseConfig", typeJson: "{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfigList\"}")]
        public virtual aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfigList Ec2AsgCapacityIncreaseConfig
        {
            get => GetInstanceProperty<aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfigList>()!;
        }

        [JsiiProperty(name: "ecsCapacityIncreaseConfig", typeJson: "{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfigList\"}")]
        public virtual aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfigList EcsCapacityIncreaseConfig
        {
            get => GetInstanceProperty<aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfigList>()!;
        }

        [JsiiProperty(name: "eksResourceScalingConfig", typeJson: "{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigList\"}")]
        public virtual aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigList EksResourceScalingConfig
        {
            get => GetInstanceProperty<aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfigList>()!;
        }

        [JsiiProperty(name: "executionApprovalConfig", typeJson: "{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepExecutionApprovalConfigList\"}")]
        public virtual aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepExecutionApprovalConfigList ExecutionApprovalConfig
        {
            get => GetInstanceProperty<aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepExecutionApprovalConfigList>()!;
        }

        [JsiiProperty(name: "globalAuroraConfig", typeJson: "{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepGlobalAuroraConfigList\"}")]
        public virtual aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepGlobalAuroraConfigList GlobalAuroraConfig
        {
            get => GetInstanceProperty<aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepGlobalAuroraConfigList>()!;
        }

        [JsiiProperty(name: "regionSwitchPlanConfig", typeJson: "{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRegionSwitchPlanConfigList\"}")]
        public virtual aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRegionSwitchPlanConfigList RegionSwitchPlanConfig
        {
            get => GetInstanceProperty<aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRegionSwitchPlanConfigList>()!;
        }

        [JsiiProperty(name: "route53HealthCheckConfig", typeJson: "{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfigList\"}")]
        public virtual aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfigList Route53HealthCheckConfig
        {
            get => GetInstanceProperty<aws.ArcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arcRoutingControlConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepArcRoutingControlConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ArcRoutingControlConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customActionLambdaConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepCustomActionLambdaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomActionLambdaConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "documentDbConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepDocumentDbConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DocumentDbConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2AsgCapacityIncreaseConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEc2AsgCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Ec2AsgCapacityIncreaseConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecsCapacityIncreaseConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEcsCapacityIncreaseConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EcsCapacityIncreaseConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eksResourceScalingConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepEksResourceScalingConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EksResourceScalingConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionApprovalConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepExecutionApprovalConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExecutionApprovalConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionBlockTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionBlockTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "globalAuroraConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepGlobalAuroraConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GlobalAuroraConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionSwitchPlanConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRegionSwitchPlanConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RegionSwitchPlanConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "route53HealthCheckConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStepRoute53HealthCheckConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? Route53HealthCheckConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionBlockType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionBlockType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.arcregionswitchPlan.ArcregionswitchPlanWorkflowStepParallelConfigStep\"}]}}", isOptional: true)]
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
                        case aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStep cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ArcregionswitchPlan.IArcregionswitchPlanWorkflowStepParallelConfigStep).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
