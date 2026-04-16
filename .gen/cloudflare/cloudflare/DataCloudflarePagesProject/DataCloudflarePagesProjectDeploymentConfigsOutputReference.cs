using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePagesProject
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePagesProjectDeploymentConfigsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePagesProjectDeploymentConfigsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePagesProjectDeploymentConfigsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePagesProjectDeploymentConfigsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "preview", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewOutputReference Preview
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsPreviewOutputReference>()!;
        }

        [JsiiProperty(name: "production", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionOutputReference Production
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsProductionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigs\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflarePagesProject.IDataCloudflarePagesProjectDeploymentConfigs? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.IDataCloudflarePagesProjectDeploymentConfigs?>();
            set => SetInstanceProperty(value);
        }
    }
}
