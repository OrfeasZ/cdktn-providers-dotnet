using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.OpensearchDeployment
{
    [JsiiClass(nativeType: typeof(scaleway.OpensearchDeployment.OpensearchDeploymentPrivateNetworkOutputReference), fullyQualifiedName: "scaleway.opensearchDeployment.OpensearchDeploymentPrivateNetworkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchDeploymentPrivateNetworkOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchDeploymentPrivateNetworkOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchDeploymentPrivateNetworkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchDeploymentPrivateNetworkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateNetworkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateNetworkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateNetworkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.opensearchDeployment.OpensearchDeploymentPrivateNetwork\"}", isOptional: true)]
        public virtual scaleway.OpensearchDeployment.IOpensearchDeploymentPrivateNetwork? InternalValue
        {
            get => GetInstanceProperty<scaleway.OpensearchDeployment.IOpensearchDeploymentPrivateNetwork?>();
            set => SetInstanceProperty(value);
        }
    }
}
