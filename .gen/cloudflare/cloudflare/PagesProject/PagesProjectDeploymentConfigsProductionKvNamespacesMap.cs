using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    [JsiiClass(nativeType: typeof(cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionKvNamespacesMap), fullyQualifiedName: "cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionKvNamespacesMap", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PagesProjectDeploymentConfigsProductionKvNamespacesMap : Io.Cdktn.ComplexMap
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PagesProjectDeploymentConfigsProductionKvNamespacesMap(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PagesProjectDeploymentConfigsProductionKvNamespacesMap(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PagesProjectDeploymentConfigsProductionKvNamespacesMap(DeputyProps props): base(props)
        {
        }

        /// <param name="key">the key of the item to return.</param>
        [JsiiMethod(name: "get", returnsJson: "{\"type\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionKvNamespacesOutputReference\"}}", parametersJson: "[{\"docs\":{\"summary\":\"the key of the item to return.\"},\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionKvNamespacesOutputReference Get(string key)
        {
            return InvokeInstanceMethod<cloudflare.PagesProject.PagesProjectDeploymentConfigsProductionKvNamespacesOutputReference>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsProductionKvNamespaces\"},\"kind\":\"map\"}}]}}", isOptional: true)]
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
                        case System.Collections.Generic.IDictionary<string, cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionKvNamespaces> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, {typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigsProductionKvNamespaces).FullName}>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
