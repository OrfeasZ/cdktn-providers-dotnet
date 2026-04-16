using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiClass(nativeType: typeof(cloudflare.PagesProject.PagesProjectDeploymentConfigsOutputReference), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PagesProjectDeploymentConfigsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PagesProjectDeploymentConfigsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PagesProjectDeploymentConfigsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PagesProjectDeploymentConfigsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPreview", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreview\"}}]")]
        public virtual void PutPreview(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreview @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreview)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProduction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProduction\"}}]")]
        public virtual void PutProduction(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProduction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProduction)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPreview")]
        public virtual void ResetPreview()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProduction")]
        public virtual void ResetProduction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "preview", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsPreviewOutputReference Preview
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsPreviewOutputReference>()!;
        }

        [JsiiProperty(name: "production", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionOutputReference Production
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "previewInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreview\"}]}}", isOptional: true)]
        public virtual object? PreviewInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProduction\"}]}}", isOptional: true)]
        public virtual object? ProductionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigs\"}]}}", isOptional: true)]
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
                        case cloudflare.PagesProject.IPagesProjectDeploymentConfigs cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigs).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
