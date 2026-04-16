using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePagesProjects
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePagesProjectsResultDeploymentConfigsPreviewOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePagesProjectsResultDeploymentConfigsPreviewOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePagesProjectsResultDeploymentConfigsPreviewOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePagesProjectsResultDeploymentConfigsPreviewOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aiBindings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewAiBindingsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewAiBindingsMap AiBindings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewAiBindingsMap>()!;
        }

        [JsiiProperty(name: "alwaysUseLatestCompatibilityDate", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AlwaysUseLatestCompatibilityDate
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "analyticsEngineDatasets", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewAnalyticsEngineDatasetsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewAnalyticsEngineDatasetsMap AnalyticsEngineDatasets
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewAnalyticsEngineDatasetsMap>()!;
        }

        [JsiiProperty(name: "browsers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewBrowsersMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewBrowsersMap Browsers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewBrowsersMap>()!;
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

        [JsiiProperty(name: "d1Databases", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewD1DatabasesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewD1DatabasesMap D1Databases
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewD1DatabasesMap>()!;
        }

        [JsiiProperty(name: "durableObjectNamespaces", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewDurableObjectNamespacesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewDurableObjectNamespacesMap DurableObjectNamespaces
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewDurableObjectNamespacesMap>()!;
        }

        [JsiiProperty(name: "envVars", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewEnvVarsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewEnvVarsMap EnvVars
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewEnvVarsMap>()!;
        }

        [JsiiProperty(name: "failOpen", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable FailOpen
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "hyperdriveBindings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewHyperdriveBindingsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewHyperdriveBindingsMap HyperdriveBindings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewHyperdriveBindingsMap>()!;
        }

        [JsiiProperty(name: "kvNamespaces", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewKvNamespacesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewKvNamespacesMap KvNamespaces
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewKvNamespacesMap>()!;
        }

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewLimitsOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewLimitsOutputReference Limits
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewLimitsOutputReference>()!;
        }

        [JsiiProperty(name: "mtlsCertificates", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewMtlsCertificatesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewMtlsCertificatesMap MtlsCertificates
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewMtlsCertificatesMap>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewPlacementOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewPlacementOutputReference Placement
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewPlacementOutputReference>()!;
        }

        [JsiiProperty(name: "queueProducers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewQueueProducersMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewQueueProducersMap QueueProducers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewQueueProducersMap>()!;
        }

        [JsiiProperty(name: "r2Buckets", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewR2BucketsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewR2BucketsMap R2Buckets
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewR2BucketsMap>()!;
        }

        [JsiiProperty(name: "services", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewServicesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewServicesMap Services
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewServicesMap>()!;
        }

        [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vectorizeBindings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewVectorizeBindingsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewVectorizeBindingsMap VectorizeBindings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewVectorizeBindingsMap>()!;
        }

        [JsiiProperty(name: "wranglerConfigHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WranglerConfigHash
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreview\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePagesProjects.IDataCloudflarePagesProjectsResultDeploymentConfigsPreview? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.IDataCloudflarePagesProjectsResultDeploymentConfigsPreview?>();
            set => SetInstanceProperty(value);
        }
    }
}
