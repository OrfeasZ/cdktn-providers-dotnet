using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDevopsDeployStage
{
    [JsiiClass(nativeType: typeof(oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageContainerConfigOutputReference), fullyQualifiedName: "oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageContainerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDevopsDeployStageContainerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDevopsDeployStageContainerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsDeployStageContainerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsDeployStageContainerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "containerConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerConfigType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkChannel", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageContainerConfigNetworkChannelList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageContainerConfigNetworkChannelList NetworkChannel
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageContainerConfigNetworkChannelList>()!;
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageContainerConfigShapeConfigList\"}")]
        public virtual oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageContainerConfigShapeConfigList ShapeConfig
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.DataOciDevopsDeployStageContainerConfigShapeConfigList>()!;
        }

        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployStage.DataOciDevopsDeployStageContainerConfig\"}", isOptional: true)]
        public virtual oci.DataOciDevopsDeployStage.IDataOciDevopsDeployStageContainerConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployStage.IDataOciDevopsDeployStageContainerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
