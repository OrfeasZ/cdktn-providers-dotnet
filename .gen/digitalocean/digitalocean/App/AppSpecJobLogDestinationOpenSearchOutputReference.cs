using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecJobLogDestinationOpenSearchOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecJobLogDestinationOpenSearchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppSpecJobLogDestinationOpenSearchOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppSpecJobLogDestinationOpenSearchOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppSpecJobLogDestinationOpenSearchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecJobLogDestinationOpenSearchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBasicAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationOpenSearchBasicAuth\"}}]")]
        public virtual void PutBasicAuth(digitalocean.App.IAppSpecJobLogDestinationOpenSearchBasicAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecJobLogDestinationOpenSearchBasicAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClusterName")]
        public virtual void ResetClusterName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpoint")]
        public virtual void ResetEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndexName")]
        public virtual void ResetIndexName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "basicAuth", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationOpenSearchBasicAuthOutputReference\"}")]
        public virtual digitalocean.App.AppSpecJobLogDestinationOpenSearchBasicAuthOutputReference BasicAuth
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecJobLogDestinationOpenSearchBasicAuthOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "basicAuthInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationOpenSearchBasicAuth\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecJobLogDestinationOpenSearchBasicAuth? BasicAuthInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecJobLogDestinationOpenSearchBasicAuth?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IndexNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndexName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecJobLogDestinationOpenSearch\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecJobLogDestinationOpenSearch? InternalValue
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecJobLogDestinationOpenSearch?>();
            set => SetInstanceProperty(value);
        }
    }
}
