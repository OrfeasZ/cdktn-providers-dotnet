using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    [JsiiClass(nativeType: typeof(oci.BdsBdsInstance.BdsBdsInstanceKafkaBrokerNodeOutputReference), fullyQualifiedName: "oci.bdsBdsInstance.BdsBdsInstanceKafkaBrokerNodeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BdsBdsInstanceKafkaBrokerNodeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BdsBdsInstanceKafkaBrokerNodeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BdsBdsInstanceKafkaBrokerNodeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsBdsInstanceKafkaBrokerNodeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putShapeConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceKafkaBrokerNodeShapeConfig\"}}]")]
        public virtual void PutShapeConfig(oci.BdsBdsInstance.IBdsBdsInstanceKafkaBrokerNodeShapeConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsBdsInstance.IBdsBdsInstanceKafkaBrokerNodeShapeConfig)}, new object[]{@value});
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

        [JsiiProperty(name: "shapeConfig", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceKafkaBrokerNodeShapeConfigOutputReference\"}")]
        public virtual oci.BdsBdsInstance.BdsBdsInstanceKafkaBrokerNodeShapeConfigOutputReference ShapeConfig
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.BdsBdsInstanceKafkaBrokerNodeShapeConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockVolumeSizeInGbsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlockVolumeSizeInGbsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfKafkaNodesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberOfKafkaNodesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shapeConfigInput", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceKafkaBrokerNodeShapeConfig\"}", isOptional: true)]
        public virtual oci.BdsBdsInstance.IBdsBdsInstanceKafkaBrokerNodeShapeConfig? ShapeConfigInput
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceKafkaBrokerNodeShapeConfig?>();
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

        [JsiiProperty(name: "numberOfKafkaNodes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfKafkaNodes
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.bdsBdsInstance.BdsBdsInstanceKafkaBrokerNode\"}", isOptional: true)]
        public virtual oci.BdsBdsInstance.IBdsBdsInstanceKafkaBrokerNode? InternalValue
        {
            get => GetInstanceProperty<oci.BdsBdsInstance.IBdsBdsInstanceKafkaBrokerNode?>();
            set => SetInstanceProperty(value);
        }
    }
}
