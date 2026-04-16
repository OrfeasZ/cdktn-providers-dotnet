using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePagesProjects
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewServicesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewServicesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the key of this item in the map.\"},\"name\":\"complexObjectKey\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePagesProjectsResultDeploymentConfigsPreviewServicesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectKey">the key of this item in the map.</param>
        public DataCloudflarePagesProjectsResultDeploymentConfigsPreviewServicesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, string complexObjectKey): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectKey))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, string complexObjectKey)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectKey});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePagesProjectsResultDeploymentConfigsPreviewServicesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePagesProjectsResultDeploymentConfigsPreviewServicesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "entrypoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Entrypoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Environment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Service
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProjects.DataCloudflarePagesProjectsResultDeploymentConfigsPreviewServices\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePagesProjects.IDataCloudflarePagesProjectsResultDeploymentConfigsPreviewServices? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProjects.IDataCloudflarePagesProjectsResultDeploymentConfigsPreviewServices?>();
            set => SetInstanceProperty(value);
        }
    }
}
