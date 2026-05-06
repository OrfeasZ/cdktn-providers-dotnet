using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePagesProject
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePagesProjectDeploymentConfigsProductionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePagesProjectDeploymentConfigsProductionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePagesProjectDeploymentConfigsProductionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePagesProjectDeploymentConfigsProductionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aiBindings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionAiBindingsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionAiBindingsMap AiBindings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionAiBindingsMap>()!;
        }

        [JsiiProperty(name: "alwaysUseLatestCompatibilityDate", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AlwaysUseLatestCompatibilityDate
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "analyticsEngineDatasets", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionAnalyticsEngineDatasetsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionAnalyticsEngineDatasetsMap AnalyticsEngineDatasets
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionAnalyticsEngineDatasetsMap>()!;
        }

        [JsiiProperty(name: "browsers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionBrowsersMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionBrowsersMap Browsers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionBrowsersMap>()!;
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

        [JsiiProperty(name: "d1Databases", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionD1DatabasesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionD1DatabasesMap D1Databases
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionD1DatabasesMap>()!;
        }

        [JsiiProperty(name: "durableObjectNamespaces", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionDurableObjectNamespacesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionDurableObjectNamespacesMap DurableObjectNamespaces
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionDurableObjectNamespacesMap>()!;
        }

        [JsiiProperty(name: "envVars", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionEnvVarsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionEnvVarsMap EnvVars
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionEnvVarsMap>()!;
        }

        [JsiiProperty(name: "failOpen", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable FailOpen
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "hyperdriveBindings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionHyperdriveBindingsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionHyperdriveBindingsMap HyperdriveBindings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionHyperdriveBindingsMap>()!;
        }

        [JsiiProperty(name: "kvNamespaces", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionKvNamespacesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionKvNamespacesMap KvNamespaces
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionKvNamespacesMap>()!;
        }

        [JsiiProperty(name: "limits", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionLimitsOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionLimitsOutputReference Limits
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionLimitsOutputReference>()!;
        }

        [JsiiProperty(name: "mtlsCertificates", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionMtlsCertificatesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionMtlsCertificatesMap MtlsCertificates
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionMtlsCertificatesMap>()!;
        }

        [JsiiProperty(name: "placement", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionPlacementOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionPlacementOutputReference Placement
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionPlacementOutputReference>()!;
        }

        [JsiiProperty(name: "queueProducers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionQueueProducersMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionQueueProducersMap QueueProducers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionQueueProducersMap>()!;
        }

        [JsiiProperty(name: "r2Buckets", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionR2BucketsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionR2BucketsMap R2Buckets
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionR2BucketsMap>()!;
        }

        [JsiiProperty(name: "services", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionServicesMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionServicesMap Services
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionServicesMap>()!;
        }

        [JsiiProperty(name: "usageModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vectorizeBindings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionVectorizeBindingsMap\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionVectorizeBindingsMap VectorizeBindings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionVectorizeBindingsMap>()!;
        }

        [JsiiProperty(name: "wranglerConfigHash", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WranglerConfigHash
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProduction\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePagesProject.IDataCloudflarePagesProjectDeploymentConfigsProduction? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.IDataCloudflarePagesProjectDeploymentConfigsProduction?>();
            set => SetInstanceProperty(value);
        }
    }
}
