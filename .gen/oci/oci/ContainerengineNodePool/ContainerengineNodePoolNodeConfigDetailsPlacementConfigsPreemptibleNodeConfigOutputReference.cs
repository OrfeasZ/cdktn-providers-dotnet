using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    [JsiiClass(nativeType: typeof(oci.ContainerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigOutputReference), fullyQualifiedName: "oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPreemptionAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionAction\"}}]")]
        public virtual void PutPreemptionAction(oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionAction)}, new object[]{@value});
        }

        [JsiiProperty(name: "preemptionAction", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionActionOutputReference\"}")]
        public virtual oci.ContainerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionActionOutputReference PreemptionAction
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionActionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preemptionActionInput", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionAction\"}", isOptional: true)]
        public virtual oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionAction? PreemptionActionInput
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfigPreemptionAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.containerengineNodePool.ContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfig\"}", isOptional: true)]
        public virtual oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfig? InternalValue
        {
            get => GetInstanceProperty<oci.ContainerengineNodePool.IContainerengineNodePoolNodeConfigDetailsPlacementConfigsPreemptibleNodeConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
