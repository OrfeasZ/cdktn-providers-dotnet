using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DevopsDeployStage
{
    [JsiiClass(nativeType: typeof(oci.DevopsDeployStage.DevopsDeployStageContainerConfigOutputReference), fullyQualifiedName: "oci.devopsDeployStage.DevopsDeployStageContainerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DevopsDeployStageContainerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DevopsDeployStageContainerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DevopsDeployStageContainerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsDeployStageContainerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNetworkChannel", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfigNetworkChannel\"}}]")]
        public virtual void PutNetworkChannel(oci.DevopsDeployStage.IDevopsDeployStageContainerConfigNetworkChannel @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageContainerConfigNetworkChannel)}, new object[]{@value});
        }

        [JsiiMethod(name: "putShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfigShapeConfig\"}}]")]
        public virtual void PutShapeConfig(oci.DevopsDeployStage.IDevopsDeployStageContainerConfigShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DevopsDeployStage.IDevopsDeployStageContainerConfigShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAvailabilityDomain")]
        public virtual void ResetAvailabilityDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompartmentId")]
        public virtual void ResetCompartmentId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "networkChannel", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfigNetworkChannelOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageContainerConfigNetworkChannelOutputReference NetworkChannel
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageContainerConfigNetworkChannelOutputReference>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfigShapeConfigOutputReference\"}")]
        public virtual oci.DevopsDeployStage.DevopsDeployStageContainerConfigShapeConfigOutputReference ShapeConfig
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.DevopsDeployStageContainerConfigShapeConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilityDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerConfigTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerConfigTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkChannelInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfigNetworkChannel\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageContainerConfigNetworkChannel? NetworkChannelInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageContainerConfigNetworkChannel?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigInput", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfigShapeConfig\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageContainerConfigShapeConfig? ShapeConfigInput
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageContainerConfigShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "containerConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerConfigType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.devopsDeployStage.DevopsDeployStageContainerConfig\"}", isOptional: true)]
        public virtual oci.DevopsDeployStage.IDevopsDeployStageContainerConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DevopsDeployStage.IDevopsDeployStageContainerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
