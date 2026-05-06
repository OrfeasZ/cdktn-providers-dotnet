using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    [JsiiClass(nativeType: typeof(oci.BdsBdsInstance.BdsBdsInstanceWorkerNodeOutputReference), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstanceWorkerNodeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BdsBdsInstanceWorkerNodeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BdsBdsInstanceWorkerNodeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BdsBdsInstanceWorkerNodeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsBdsInstanceWorkerNodeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceWorkerNodeShapeConfig\"}}]")]
        public virtual void PutShapeConfig(oci.BdsBdsInstance.IBdsBdsInstanceWorkerNodeShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstance.IBdsBdsInstanceWorkerNodeShapeConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBlockVolumeSizeInGbs")]
        public virtual void ResetBlockVolumeSizeInGbs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShapeConfig")]
        public virtual void ResetShapeConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceWorkerNodeShapeConfigOutputReference\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceWorkerNodeShapeConfigOutputReference ShapeConfig
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceWorkerNodeShapeConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockVolumeSizeInGbsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockVolumeSizeInGbsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfNodesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberOfNodesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceWorkerNodeShapeConfig\"}", isOptional: true)]
        public virtual oci.BdsBdsInstance.IBdsBdsInstanceWorkerNodeShapeConfig? ShapeConfigInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceWorkerNodeShapeConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShapeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "blockVolumeSizeInGbs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlockVolumeSizeInGbs
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numberOfNodes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfNodes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceWorkerNode\"}", isOptional: true)]
        public virtual oci.BdsBdsInstance.IBdsBdsInstanceWorkerNode? InternalValue
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceWorkerNode?>();
            set => SetInstanceProperty(value);
        }
    }
}
