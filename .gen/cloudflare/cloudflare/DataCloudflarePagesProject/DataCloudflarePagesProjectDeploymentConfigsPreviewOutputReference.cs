using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePagesProject
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePagesProjectDeploymentConfigsPreviewOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePagesProjectDeploymentConfigsPreviewOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePagesProjectDeploymentConfigsPreviewOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePagesProjectDeploymentConfigsPreviewOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aiBindings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewAiBindingsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewAiBindingsMap AiBindings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewAiBindingsMap>()!;
        }

        [JsiiProperty(name: "alwaysUseLatestCompatibilityDate", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AlwaysUseLatestCompatibilityDate
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "analyticsEngineDatasets", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewAnalyticsEngineDatasetsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewAnalyticsEngineDatasetsMap AnalyticsEngineDatasets
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewAnalyticsEngineDatasetsMap>()!;
        }

        [JsiiProperty(name: "browsers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewBrowsersMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewBrowsersMap Browsers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewBrowsersMap>()!;
        }

        [JsiiProperty(name: "buildImageMajorVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BuildImageMajorVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compatibilityDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompatibilityDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compatibilityFlags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CompatibilityFlags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "d1Databases", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewD1DatabasesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewD1DatabasesMap D1Databases
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewD1DatabasesMap>()!;
        }

        [JsiiProperty(name: "durableObjectNamespaces", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewDurableObjectNamespacesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewDurableObjectNamespacesMap DurableObjectNamespaces
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewDurableObjectNamespacesMap>()!;
        }

        [JsiiProperty(name: "envVars", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewEnvVarsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewEnvVarsMap EnvVars
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewEnvVarsMap>()!;
        }

        [JsiiProperty(name: "failOpen", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable FailOpen
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "hyperdriveBindings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewHyperdriveBindingsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewHyperdriveBindingsMap HyperdriveBindings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewHyperdriveBindingsMap>()!;
        }

        [JsiiProperty(name: "kvNamespaces", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewKvNamespacesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewKvNamespacesMap KvNamespaces
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewKvNamespacesMap>()!;
        }

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewLimitsOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewLimitsOutputReference Limits
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewLimitsOutputReference>()!;
        }

        [JsiiProperty(name: "mtlsCertificates", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewMtlsCertificatesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewMtlsCertificatesMap MtlsCertificates
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewMtlsCertificatesMap>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewPlacementOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewPlacementOutputReference Placement
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewPlacementOutputReference>()!;
        }

        [JsiiProperty(name: "queueProducers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewQueueProducersMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewQueueProducersMap QueueProducers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewQueueProducersMap>()!;
        }

        [JsiiProperty(name: "r2Buckets", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewR2BucketsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewR2BucketsMap R2Buckets
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewR2BucketsMap>()!;
        }

        [JsiiProperty(name: "services", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewServicesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewServicesMap Services
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewServicesMap>()!;
        }

        [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vectorizeBindings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewVectorizeBindingsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewVectorizeBindingsMap VectorizeBindings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewVectorizeBindingsMap>()!;
        }

        [JsiiProperty(name: "wranglerConfigHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WranglerConfigHash
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreview\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePagesProject.IDataCloudflarePagesProjectDeploymentConfigsPreview? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.IDataCloudflarePagesProjectDeploymentConfigsPreview?>();
            set => SetInstanceProperty(value);
        }
    }
}
