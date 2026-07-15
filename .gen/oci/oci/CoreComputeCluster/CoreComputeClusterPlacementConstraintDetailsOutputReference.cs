using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreComputeCluster
{
    [JsiiClass(nativeType: typeof(oci.CoreComputeCluster.CoreComputeClusterPlacementConstraintDetailsOutputReference), fullyQualifiedName: "oci.coreComputeCluster.CoreComputeClusterPlacementConstraintDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreComputeClusterPlacementConstraintDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreComputeClusterPlacementConstraintDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreComputeClusterPlacementConstraintDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreComputeClusterPlacementConstraintDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHpcIslandId")]
        public virtual void ResetHpcIslandId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogicalPlacementConstraint")]
        public virtual void ResetLogicalPlacementConstraint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetMemoryFabricIds")]
        public virtual void ResetTargetMemoryFabricIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetNetworkBlockIds")]
        public virtual void ResetTargetNetworkBlockIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "hpcIslandIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HpcIslandIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logicalPlacementConstraintInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogicalPlacementConstraintInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetMemoryFabricIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TargetMemoryFabricIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetNetworkBlockIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TargetNetworkBlockIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hpcIslandId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HpcIslandId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logicalPlacementConstraint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogicalPlacementConstraint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetMemoryFabricIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetMemoryFabricIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetNetworkBlockIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetNetworkBlockIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreComputeCluster.CoreComputeClusterPlacementConstraintDetails\"}", isOptional: true)]
        public virtual oci.CoreComputeCluster.ICoreComputeClusterPlacementConstraintDetails? InternalValue
        {
            get => GetInstanceProperty<oci.CoreComputeCluster.ICoreComputeClusterPlacementConstraintDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
