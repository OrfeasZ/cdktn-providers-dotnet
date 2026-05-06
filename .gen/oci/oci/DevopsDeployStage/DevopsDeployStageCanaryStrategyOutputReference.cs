using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiClass(nativeType: typeof(oci.DevopsDeployStage.DevopsDeployStageCanaryStrategyOutputReference), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageCanaryStrategyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DevopsDeployStageCanaryStrategyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DevopsDeployStageCanaryStrategyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DevopsDeployStageCanaryStrategyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsDeployStageCanaryStrategyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "ingressNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IngressNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespaceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamespaceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "strategyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StrategyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "ingressName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IngressName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "strategyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StrategyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageCanaryStrategy\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageCanaryStrategy? InternalValue
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageCanaryStrategy?>();
            set => SetInstanceProperty(value);
        }
    }
}
