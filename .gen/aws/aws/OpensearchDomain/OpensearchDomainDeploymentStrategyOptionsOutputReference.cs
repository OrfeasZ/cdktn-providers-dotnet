using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiClass(nativeType: typeof(aws.OpensearchDomain.OpensearchDomainDeploymentStrategyOptionsOutputReference), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainDeploymentStrategyOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchDomainDeploymentStrategyOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchDomainDeploymentStrategyOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchDomainDeploymentStrategyOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchDomainDeploymentStrategyOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "deploymentStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainDeploymentStrategyOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainDeploymentStrategyOptions? InternalValue
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainDeploymentStrategyOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
