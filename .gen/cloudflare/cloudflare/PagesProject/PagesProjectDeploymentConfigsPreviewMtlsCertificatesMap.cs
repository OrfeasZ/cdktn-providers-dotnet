using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiClass(nativeType: typeof(cloudflare.PagesProject.PagesProjectDeploymentConfigsPreviewMtlsCertificatesMap), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewMtlsCertificatesMap", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PagesProjectDeploymentConfigsPreviewMtlsCertificatesMap : Io.Cdktn.ComplexMap
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PagesProjectDeploymentConfigsPreviewMtlsCertificatesMap(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PagesProjectDeploymentConfigsPreviewMtlsCertificatesMap(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PagesProjectDeploymentConfigsPreviewMtlsCertificatesMap(DeputyProps props): base(props)
        {
        }

        /// <param name="key">the key of the item to return.</param>
        [JsiiMethod(name: "get", returnsJson: "{\"type\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewMtlsCertificatesOutputReference\"}}", parametersJson: "[{\"docs\":{\"summary\":\"the key of the item to return.\"},\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsPreviewMtlsCertificatesOutputReference Get(string key)
        {
            return InvokeInstanceMethod<cloudflare.PagesProject.PagesProjectDeploymentConfigsPreviewMtlsCertificatesOutputReference>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsPreviewMtlsCertificates\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewMtlsCertificates> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsPreviewMtlsCertificates).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
