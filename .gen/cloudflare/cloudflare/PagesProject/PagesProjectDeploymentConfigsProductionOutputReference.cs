using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiClass(nativeType: typeof(cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionOutputReference), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PagesProjectDeploymentConfigsProductionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PagesProjectDeploymentConfigsProductionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PagesProjectDeploymentConfigsProductionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PagesProjectDeploymentConfigsProductionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAiBindings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAiBindings\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutAiBindings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAiBindings> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAiBindings).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAiBindings).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAnalyticsEngineDatasets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutAnalyticsEngineDatasets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBrowsers", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionBrowsers\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutBrowsers(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionBrowsers> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionBrowsers).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionBrowsers).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putD1Databases", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionD1Databases\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutD1Databases(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionD1Databases> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionD1Databases).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionD1Databases).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDurableObjectNamespaces", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionDurableObjectNamespaces\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutDurableObjectNamespaces(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionDurableObjectNamespaces> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionDurableObjectNamespaces).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionDurableObjectNamespaces).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnvVars", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionEnvVars\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutEnvVars(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionEnvVars> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionEnvVars).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionEnvVars).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHyperdriveBindings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionHyperdriveBindings\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutHyperdriveBindings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionHyperdriveBindings> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionHyperdriveBindings).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionHyperdriveBindings).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKvNamespaces", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionKvNamespaces\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutKvNamespaces(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionKvNamespaces> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionKvNamespaces).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionKvNamespaces).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLimits", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionLimits\"}}]")]
        public virtual void PutLimits(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionLimits @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionLimits)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMtlsCertificates", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionMtlsCertificates\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutMtlsCertificates(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionMtlsCertificates> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionMtlsCertificates).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionMtlsCertificates).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionPlacement\"}}]")]
        public virtual void PutPlacement(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionPlacement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionPlacement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueueProducers", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionQueueProducers\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutQueueProducers(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionQueueProducers> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionQueueProducers).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionQueueProducers).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putR2Buckets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionR2Buckets\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutR2Buckets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionR2Buckets> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionR2Buckets).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionR2Buckets).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServices", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionServices\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutServices(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionServices> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionServices).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionServices).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVectorizeBindings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionVectorizeBindings\"},\"kind\":\"map\"}}]}}}]")]
        public virtual void PutVectorizeBindings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionVectorizeBindings> cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionVectorizeBindings).FullName}>; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionVectorizeBindings).FullName}>; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAiBindings")]
        public virtual void ResetAiBindings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAlwaysUseLatestCompatibilityDate")]
        public virtual void ResetAlwaysUseLatestCompatibilityDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAnalyticsEngineDatasets")]
        public virtual void ResetAnalyticsEngineDatasets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBrowsers")]
        public virtual void ResetBrowsers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildImageMajorVersion")]
        public virtual void ResetBuildImageMajorVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompatibilityDate")]
        public virtual void ResetCompatibilityDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompatibilityFlags")]
        public virtual void ResetCompatibilityFlags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetD1Databases")]
        public virtual void ResetD1Databases()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDurableObjectNamespaces")]
        public virtual void ResetDurableObjectNamespaces()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvVars")]
        public virtual void ResetEnvVars()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFailOpen")]
        public virtual void ResetFailOpen()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHyperdriveBindings")]
        public virtual void ResetHyperdriveBindings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKvNamespaces")]
        public virtual void ResetKvNamespaces()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLimits")]
        public virtual void ResetLimits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMtlsCertificates")]
        public virtual void ResetMtlsCertificates()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacement")]
        public virtual void ResetPlacement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueueProducers")]
        public virtual void ResetQueueProducers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetR2Buckets")]
        public virtual void ResetR2Buckets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServices")]
        public virtual void ResetServices()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsageModel")]
        public virtual void ResetUsageModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVectorizeBindings")]
        public virtual void ResetVectorizeBindings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWranglerConfigHash")]
        public virtual void ResetWranglerConfigHash()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "aiBindings", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAiBindingsMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionAiBindingsMap AiBindings
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionAiBindingsMap>()!;
        }

        [JsiiProperty(name: "analyticsEngineDatasets", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasetsMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasetsMap AnalyticsEngineDatasets
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasetsMap>()!;
        }

        [JsiiProperty(name: "browsers", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionBrowsersMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionBrowsersMap Browsers
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionBrowsersMap>()!;
        }

        [JsiiProperty(name: "d1Databases", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionD1DatabasesMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionD1DatabasesMap D1Databases
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionD1DatabasesMap>()!;
        }

        [JsiiProperty(name: "durableObjectNamespaces", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionDurableObjectNamespacesMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionDurableObjectNamespacesMap DurableObjectNamespaces
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionDurableObjectNamespacesMap>()!;
        }

        [JsiiProperty(name: "envVars", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionEnvVarsMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionEnvVarsMap EnvVars
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionEnvVarsMap>()!;
        }

        [JsiiProperty(name: "hyperdriveBindings", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionHyperdriveBindingsMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionHyperdriveBindingsMap HyperdriveBindings
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionHyperdriveBindingsMap>()!;
        }

        [JsiiProperty(name: "kvNamespaces", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionKvNamespacesMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionKvNamespacesMap KvNamespaces
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionKvNamespacesMap>()!;
        }

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionLimitsOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionLimitsOutputReference Limits
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionLimitsOutputReference>()!;
        }

        [JsiiProperty(name: "mtlsCertificates", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionMtlsCertificatesMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionMtlsCertificatesMap MtlsCertificates
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionMtlsCertificatesMap>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionPlacementOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionPlacementOutputReference Placement
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionPlacementOutputReference>()!;
        }

        [JsiiProperty(name: "queueProducers", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionQueueProducersMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionQueueProducersMap QueueProducers
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionQueueProducersMap>()!;
        }

        [JsiiProperty(name: "r2Buckets", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionR2BucketsMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionR2BucketsMap R2Buckets
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionR2BucketsMap>()!;
        }

        [JsiiProperty(name: "services", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionServicesMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionServicesMap Services
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionServicesMap>()!;
        }

        [JsiiProperty(name: "vectorizeBindings", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionVectorizeBindingsMap\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionVectorizeBindingsMap VectorizeBindings
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionVectorizeBindingsMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aiBindingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAiBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? AiBindingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "alwaysUseLatestCompatibilityDateInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AlwaysUseLatestCompatibilityDateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "analyticsEngineDatasetsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionAnalyticsEngineDatasets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? AnalyticsEngineDatasetsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "browsersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionBrowsers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? BrowsersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildImageMajorVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BuildImageMajorVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compatibilityDateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompatibilityDateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compatibilityFlagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CompatibilityFlagsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "d1DatabasesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionD1Databases\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? D1DatabasesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "durableObjectNamespacesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionDurableObjectNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? DurableObjectNamespacesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "envVarsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionEnvVars\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? EnvVarsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "failOpenInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FailOpenInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hyperdriveBindingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionHyperdriveBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? HyperdriveBindingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kvNamespacesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionKvNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? KvNamespacesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "limitsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionLimits\"}]}}", isOptional: true)]
        public virtual object? LimitsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mtlsCertificatesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionMtlsCertificates\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? MtlsCertificatesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionPlacement\"}]}}", isOptional: true)]
        public virtual object? PlacementInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queueProducersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionQueueProducers\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? QueueProducersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "r2BucketsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionR2Buckets\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? R2BucketsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "servicesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionServices\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? ServicesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vectorizeBindingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionVectorizeBindings\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? VectorizeBindingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "wranglerConfigHashInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WranglerConfigHashInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "alwaysUseLatestCompatibilityDate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AlwaysUseLatestCompatibilityDate
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "buildImageMajorVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BuildImageMajorVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compatibilityDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompatibilityDate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compatibilityFlags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CompatibilityFlags
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "failOpen", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object FailOpen
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "wranglerConfigHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WranglerConfigHash
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProduction\"}]}}", isOptional: true)]
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
                        case cloudflare.PagesProject.IPagesProjectDeploymentConfigsProduction cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProduction).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
