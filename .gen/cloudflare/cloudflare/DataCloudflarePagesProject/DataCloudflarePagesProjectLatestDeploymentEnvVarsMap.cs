using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePagesProject
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectLatestDeploymentEnvVarsMap), fullyQualifiedName: "cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectLatestDeploymentEnvVarsMap", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflarePagesProjectLatestDeploymentEnvVarsMap : Io.Cdktn.ComplexMap
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflarePagesProjectLatestDeploymentEnvVarsMap(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflarePagesProjectLatestDeploymentEnvVarsMap(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePagesProjectLatestDeploymentEnvVarsMap(DeputyProps props): base(props)
        {
        }

        /// <param name="key">the key of the item to return.</param>
        [JsiiMethod(name: "get", returnsJson: "{\"type\":{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectLatestDeploymentEnvVarsOutputReference\"}}", parametersJson: "[{\"docs\":{\"summary\":\"the key of the item to return.\"},\"name\":\"key\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectLatestDeploymentEnvVarsOutputReference Get(string key)
        {
            return InvokeInstanceMethod<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectLatestDeploymentEnvVarsOutputReference>(new System.Type[]{typeof(string)}, new object[]{key})!;
        }
    }
}
